using System.Collections.Generic;

namespace UMSTestJS.Models.ViewModels
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public Department Department { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Department> Departments { get; set; }
    }
}