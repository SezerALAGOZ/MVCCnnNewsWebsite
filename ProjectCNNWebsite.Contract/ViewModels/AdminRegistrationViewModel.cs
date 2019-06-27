using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCNNWebsite.Contract.ViewModels
{
   public class AdminRegistrationViewModel
   {
      [Required(ErrorMessage = "Firstname area cannot be empty.")]
      [Range(1, 50, ErrorMessage = "Firstname can be between 1 and 50 characters.")]
      public string AdminFirstName { get; set; }

      [Required(ErrorMessage = "Lastname area cannot be empty.")]
      [Range(1, 50, ErrorMessage = "Lastname can be between 1 and 50 characters.")]
      public string AdminLastName { get; set; }

      [Required(ErrorMessage ="You must provide a valid e-mail.")]     
      public string AdminEmailAddress { get; set; }

      [Required(ErrorMessage = "You must provide a username")]
      public string AdminNickName { get; set; }

      [Required(ErrorMessage = "You must provide an alpha-numerical password.")]
      [Range(8, 15, ErrorMessage = "Your password must be at least 8 and at most 15 characters.")]
      public string AdminPassword { get; set; }
   }
}
