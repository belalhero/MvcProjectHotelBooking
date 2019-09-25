using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyRoomBookingProject.Models;

namespace MyRoomBookingProject.Controllers
{
    public class HotelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Hotels
        public ActionResult AddNewHotel()
        {
            return View(db.Hotels.ToList());
        }

        public ActionResult HotelList()
        {
            return View(db.Hotels.ToList());
        }

        public ActionResult SaveData(Hotel item)
        {
            if (item.HotelName != null && item.Details != null && item.ImageUpload != null)
            {
                string fileName = Path.GetFileNameWithoutExtension(item.ImageUpload.FileName);
                string extension = Path.GetExtension(item.ImageUpload.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssff") + extension;
                item.PicUrl = fileName;
                item.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/AppFile/Images"), fileName));
                db.Hotels.Add(item);
                db.SaveChanges();
            }
            var result = "Successfully Added";
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult HotelList2(int? id)
        {
            Hotel hotel = db.Hotels.Find(id);
            return View(db.Hotels.ToList());
        }
    }
}
