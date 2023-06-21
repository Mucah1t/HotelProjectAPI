using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DTOLayer.DTOs.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage ="Please, enter a room number.")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Please, enter price of the room.")]
        public int Prüce { get; set; }
        [Required(ErrorMessage = "Please, enter a title of the room.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please, enter the number of the bed.")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Please, enter the number of the bath.")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
