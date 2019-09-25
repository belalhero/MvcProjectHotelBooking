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
    public class RoomsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Rooms
        public ActionResult AddNewRoom()
        {
            ViewBag.HotelID = new SelectList(db.Hotels, "HotelID", "HotelName");
            ViewBag.RoomTypeID = new SelectList(db.RoomTypes, "RoomTypeID", "RoomTypeName");

            return View(db.Rooms.ToList());
        }
        public ActionResult AvailableRooms()
        {
            return View(db.Rooms.ToList());
        }

        public ActionResult AllRooms()
        {
            return View(db.Rooms.ToList());
        }

        public ActionResult RoomDetails()
        {
            return View(db.Rooms.ToList());
        }

        public ActionResult SaveData(Room item)
        {
            if (item.Description != null)
            {
                string fileName = Path.GetFileNameWithoutExtension(item.ImageUpload.FileName);
                string extension = Path.GetExtension(item.ImageUpload.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssff") + extension;
                item.PicUrl = fileName;
                item.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/AppFile/Images"), fileName));
                db.Rooms.Add(item);
                db.SaveChanges();
            }
            var result = "Successfully Added";
            return Json(result, JsonRequestBehavior.AllowGet);
        }



        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Room room = db.Rooms.Find(id);
            if (room == null)
            {
                return HttpNotFound();
            }
            return View(room);
        }

        public ActionResult BookingInformation(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Room room = db.Rooms.Find(id);
            if (room == null)
            {
                return HttpNotFound();
            }
            return View(room);
        }
    }
}
