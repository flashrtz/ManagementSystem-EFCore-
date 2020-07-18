using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Empit.Core.Models
{
    public class UserManagementModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        //[Display(Name = "Employee Id")]
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="varchar(150)")]
        //[Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }

        [Required]
        [Column(TypeName = "varchar(150)")]
        public string EmployeeNumber { get; set; }
       
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string Category { get; set; }

      
        public string Password { get; set; }
    }
}
