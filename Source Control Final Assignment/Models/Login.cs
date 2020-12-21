using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Source_Control_Final_Assignment.Models
{
    public class Login
    {
        [Required]
        [StringLength(20, MinimumLength = 2)]
        [Display(Name = "user Name")]
        public string username { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        [Display(Name = "email")]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2)]
        [Display(Name = "password")]
        [DataType(DataType.Password)]
        public string password { get; set; }

    }
}