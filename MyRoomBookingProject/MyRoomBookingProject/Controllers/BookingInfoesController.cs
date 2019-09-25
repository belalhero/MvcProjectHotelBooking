using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyRoomBookingProject.Models;

namespace MyRoomBookingProject.Controllers
{
    public class BookingInfoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BookingInfoes
        public ActionResult Index()
        {
            return View(db.BookingInfoes.ToList());
        }

        public ActionResult SaveData(BookingInfo item)
        {
            if(ModelState.IsValid)
            {
                db.BookingInfoes.Add(item);
                db.SaveChanges();
            }
            else
            {
                var error = "data not valied!!!";
                return Json(error, JsonRequestBehavior.AllowGet);
            }
            var result = "Successfully Added";
            return Json(result, JsonRequestBehavior.AllowGet);
        }        
    }
}
