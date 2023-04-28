using Crud_In_CoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_In_CoreMVC.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
