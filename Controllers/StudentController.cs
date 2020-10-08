using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UMSTestJS.Data;
using UMSTestJS.Models;
using UMSTestJS.Models.ViewModels;

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
                Students = context.Students.ToList()
            };
        }
        public IActionResult Index() => View(studentViewModel);
        public IActionResult Create() => View();

        [HttpPost, ValidateAntiForgeryToken, ActionName("Create")]
        public async Task<IActionResult> CreatePOST()
        {
            
            if(ModelState.IsValid)
            {
                await context.Students.AddAsync(studentViewModel.Student);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        public async Task<IActionResult> RegisterStudent(Student student)
        {
            if(ModelState.IsValid)
            {
                await context.Students.AddAsync(student);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}