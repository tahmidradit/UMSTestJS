using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UMSTestJS.Data;
using UMSTestJS.Models;
using UMSTestJS.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace UMSTestJS.Controllers
{
    public class StudentController : Controller
    {
        private readonly UMSTestJSDbContext context;
        public IConfiguration configuration { get; }

        [BindProperty]
        public StudentViewModel studentViewModel { get; set; }
        public StudentController(UMSTestJSDbContext context, IConfiguration configuration)
        {
            this.configuration = configuration;
            this.context = context;
            studentViewModel = new StudentViewModel()
            {
                Student = new Student(),
                Department = new Department(),
                Students = context.Students.ToList(),
                Departments = context.Departments.ToList(),
            };
        }
        public IActionResult Index()
        {
            return View(studentViewModel);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                await context.Students.AddAsync(student);
                await context.SaveChangesAsync();
            }
            return RedirectToAction();
        }
        public async Task<IActionResult> DepartmentsListJsonReturn()
        {
            List<Department> departments = new List<Department>();
            departments = await (from department in context.Departments select department).ToListAsync();
            return Json(new SelectList(departments, "Id", "Name"));
            //return new JsonResult(departments);
            //return Json(context.Departments.Select(m => new { Id = m.Id, Name = m.Name})); 
        }

        [HttpPost,ValidateAntiForgeryToken]
        public async Task<IActionResult> AddDepartment(Department department)
        {
            if(ModelState.IsValid)
            {
                await context.Departments.AddAsync(department);
                await context.SaveChangesAsync();   
            }
            return RedirectToAction();
        }
    }
}