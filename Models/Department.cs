using System.ComponentModel.DataAnnotations;

namespace UMSTestJS.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}