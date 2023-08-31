using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTOs.RegisterDTO
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "This field cannot be left blank.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank.")]
        [Compare("Password",ErrorMessage ="The passwords are not same.")]
        public string ConfirmPassword { get; set; }

  
    }
}
