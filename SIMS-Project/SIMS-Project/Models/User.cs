using System.ComponentModel.DataAnnotations;

namespace SIMS_Project.Models
{
    public class User
    {
        [Key] // Primary Key
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [StringLength(20)]
        public string UserRole { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
