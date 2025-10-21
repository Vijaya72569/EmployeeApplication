using System.ComponentModel.DataAnnotations;

namespace EmployeeWebApplication.Models
{
    public class Emp
    {
        // write employee properties here
        [Key]
        public int Eid { get; set; }
        public string? Ename { get; set; }
       //public string? Position { get; set; }
        public decimal Salary { get; set; }

    }
}
