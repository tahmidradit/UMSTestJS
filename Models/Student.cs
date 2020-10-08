using System.ComponentModel.DataAnnotations;

namespace UMSTestJS.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; }

        [Required, StringLength(80)]
        public string  Department { get; set; }
    }
}