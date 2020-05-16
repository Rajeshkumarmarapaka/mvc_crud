using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcEFWebApi.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(200)")]
        [Display(Name ="Full Name")]
        public string FullName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Emp Code")]
        public string EMPCode { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Mobile { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Position { get; set; }
    }
}
