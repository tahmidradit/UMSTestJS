using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UMSTestJS.Data;
using UMSTestJS.Models;
using UMSTestJS.Models.ViewModels;

namespace UMSTestJS.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly UMSTestJSDbContext context;

        [BindProperty]
        public StudentViewModel studentViewModel { get; set; }
        public DepartmentController(UMSTestJSDbContext context)
        {
            this.context = context;
            studentViewModel = new StudentViewModel()
            {
                Department = new Department(),
                Departments = context.Departments.ToList()
            };
        }
        public IActionResult Index() => View(studentViewModel);
        
        public async Task<IActionResult> AddDepartment(Department department)
        {
            if(ModelState.IsValid)
            {
                await context.Departments.AddAsync(department);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
    }
}