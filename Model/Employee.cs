

using System.ComponentModel.DataAnnotations;

namespace CRUDWebAPI.Model
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get;set; } 
        [Required]
        public string Name { get; set; }

        [Required]
        public string Department { get; set; }

    }
}
