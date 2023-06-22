using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTOs.LoginDTO
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Enter your username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Enter your password")]
        public string Password { get; set; }

    }
}
