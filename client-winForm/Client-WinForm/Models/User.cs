﻿

using Client_WinForm.Validations;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Client_WinForm.Models
{
    public class User
    {
        public User()
        {
         
        }
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "name is required")]
        [MinLength(2, ErrorMessage = "name must be more than 2 chars"), MaxLength(15, ErrorMessage = "name must be less than 15 chars")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "password is required")]

        [MinLength(64), MaxLength(64)]
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "email is required")]
 
        [EmailAddress]
        public string Email { get; set; }

        [MinLength(20),MaxLength(50)]
      
        public string UserComputer { get; set; } = "";

        public decimal NumHoursWork { get; set; } = 9;

        public int? ManagerId { get; set; }

        public int StatusId { get; set; }

        [DefaultValue(true)]
        public bool IsNewWorker { get; set; }
     
        public Status statusObj { get; set; }


    }
}
