using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniProject.Model
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        public int Eid { get; set; }
        [Required]
        public string? Ename { get; set; }
        [Required]
        public int salary { get; set; }
        [Required]
        public int Deptid { get; set; }
    }
}
