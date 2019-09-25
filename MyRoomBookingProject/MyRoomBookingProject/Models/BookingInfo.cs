using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyRoomBookingProject.Models
{
    public class BookingInfo
    {
        public int BookingInfoID { get; set; }
        public string HotelName { get; set; }
        public string RoomType { get; set; }
        public int MaxNumberOfGuest { get; set; }
        public int NumberOfBed { get; set; }
        public decimal PricePerNight { get; set; }
        public int NumberOfDays { get; set; }
        public string GuestName { get; set; }
        public string MobileNo { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime ExpectedCheckOut { get; set; }
    }
}