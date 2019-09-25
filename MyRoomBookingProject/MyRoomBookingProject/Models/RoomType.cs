using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyRoomBookingProject.Models
{
    public class RoomType
    {
        [Key]
        public int RoomTypeID { get; set; }
        public string RoomTypeName { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}