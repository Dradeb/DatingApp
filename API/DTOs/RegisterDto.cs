using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    //Data transfer object for Registering a User
    public class RegisterDto
    {

        [Required]
        [MaxLength(20)]
        public string Username { get; set; }
        
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }
}
