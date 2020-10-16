using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UMSTestJS.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        
        [Required, StringLength(80)]
        public string Name { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        
    }
}