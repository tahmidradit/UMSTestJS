using Microsoft.EntityFrameworkCore;
using UMSTestJS.Models;

namespace UMSTestJS.Data
{
    public class UMSTestJSDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public UMSTestJSDbContext(DbContextOptions<UMSTestJSDbContext>options)
        :base(options)
        {
            
        }
    }
}