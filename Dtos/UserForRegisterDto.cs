using System.ComponentModel.DataAnnotations;

namespace NavPark_API.Dtos
{
    public class UserForRegisterDto
    {
         [Required(ErrorMessage = "Please do NOT leave empty username")]
        public string Username { get; set; } 
        [Required(ErrorMessage = "Please do NOT leave empty password")]
        [StringLength(12, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 8 characters!")]
        public string Password { get; set; }
    }
}