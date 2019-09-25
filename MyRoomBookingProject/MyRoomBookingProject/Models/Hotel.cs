using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyRoomBookingProject.Models
{
    public class Hotel
    {
        [Key]
        public int HotelID { get; set; }
        public string HotelName { get; set; }
        public string Details { get; set; }
        public string PicUrl { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}