using System.ComponentModel.DataAnnotations;

namespace UMSTestJS.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; }
    }
}