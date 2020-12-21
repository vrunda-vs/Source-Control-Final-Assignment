using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Source_Control_Final_Assignment.DataValidation;
using Source_Control_Final_Assignment.Models;
namespace Source_Control_Final_Assignment.Models
{
    public class Registration
    {
        [Required]
        [StringLength(20, MinimumLength = 2)]
        [Display(Name ="First Name")]
        public string firstname { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string lastname { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string address { get; set; }

        [Required]
        [Display(Name = "City")]
        public string city { get; set; }

        [Required]
        [Display(Name = "State")]
        public string state { get; set; }

        [Required]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Mobile No")]
        public int phone { get; set; }


        [Required]
        [Display(Name = "Upload your image")]
        public string image { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        [DataType(DataType.Date)]
        [DateValidation(ErrorMessage = "Sorry, the date can't be later than today's date")]
        [Display(Name = "Hire Date")]
        public DateTime hiringdate { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Invalid Email address")]
        [Display(Name = "Email Id")]
        public string email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        
        public string password { get; set; }
        public string UploadUserFile(HttpPostedFileBase image)
        {
            try
            {
                var Types = new[] { "png", "jpeg", "jpg" };
                var fileExt = System.IO.Path.GetExtension(image.FileName).Substring(1);
                if (!Types.Contains(fileExt))
                {
                    ErrorMessage = "File Extension Is InValid - Only Upload WORD/PDF/EXCEL/TXT File";
                    return ErrorMessage;
                }
                 else
                {
                    ErrorMessage = "File Is Successfully Uploaded";
                    return ErrorMessage;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = "Upload Container Should Not Be Empty or Contact Admin";
                return ErrorMessage;
            }
        }
        public string ErrorMessage { get; set; }







    }
}