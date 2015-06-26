using System.ComponentModel.DataAnnotations;

namespace Advent.Areas.Install.Models
{
    public class SetupViewModel
    {
        // Website details
        [Required]
        [Display(Name = "Website Name")]
        public string WebsiteName { get; set; }

        // Administrator account
        [Required]
        [MaxLength(50)]
        [RegularExpression(@"^\S*$", ErrorMessage = "No white space allowed for the Admin Username.")]
        [Display(Name = "Admin Username")]
        public string AdminName { get; set; }

        [Required]
        [MinLength(5)]
        [DataType(DataType.Password)]
        [Display(Name = "Admin Password")]
        public string AdminPassword { get; set; }

        [Required]
        [MinLength(5)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Admin Password")]
        public string AdminConfirmPassword { get; set; }

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Admin Email")]
        public string AdminEmail { get; set; }
    }
}