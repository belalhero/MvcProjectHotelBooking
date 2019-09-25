using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyRoomBookingProject.Models
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }
        public int HotelID { get; set; }
        public virtual Hotel Hotel { get; set; }
        public int RoomTypeID { get; set; }
        public virtual RoomType RoomType { get; set; }
        public int  MaxCapacity { get; set; }
        public int NumberOfBed { get; set; }
        public string Description { get; set; }
        public decimal PricePerNight { get; set; }
        public string PicUrl { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}