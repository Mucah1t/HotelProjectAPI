using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTOs.ServiceDTO
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Enter a Service's icon.")]
        public string ServiceIcon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
