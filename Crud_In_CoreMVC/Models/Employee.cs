using System.ComponentModel.DataAnnotations;

namespace Crud_In_CoreMVC.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

    }
}
