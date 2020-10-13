using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UMSTestJS.Data;
using UMSTestJS.Models;
using UMSTestJS.Models.ViewModels;
using Newtonsoft.Json.Serialization;

namespace UMSTestJS.Controllers
{
    public class StudentController : Controller
    {
        private readonly UMSTestJSDbContext context;
        
        [BindProperty]
        public StudentViewModel studentViewModel { get; set; }
        public StudentController(UMSTestJSDbContext context)
        {
            this.context = context;
            studentViewModel = new StudentViewModel()
            {
                Student = new Student(),
                Department = new Department(),
                Students = context.Students.ToList(),
                Departments = context.Departments.ToList()
            };
        }
        public IActionResult Index() => View(studentViewModel);
        public async Task<IActionResult> RegisterStudent(Student student)
        {
            if(ModelState.IsValid)
            {
                await context.Students.AddAsync(student);
                await context.SaveChangesAsync();
                
            }
            return RedirectToAction(nameof(Index));
        }
    }
}