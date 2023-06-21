using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTOs.ServiceDTO
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Enter a Service's icon.")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Enter a Service title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Enter a Service description.")]
        public string Description { get; set; }
    }
}
