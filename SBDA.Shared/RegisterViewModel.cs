using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SBDA.Shared
{
   public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}
