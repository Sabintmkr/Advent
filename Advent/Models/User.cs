using System.ComponentModel.DataAnnotations;

namespace Advent.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(80)]
        public string Password { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
    }
}