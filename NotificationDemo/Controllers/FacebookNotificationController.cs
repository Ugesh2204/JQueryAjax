using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotificationDemo.Data;
using NotificationDemo.Models;

namespace NotificationDemo.Controllers
{
    public class FacebookNotificationController : Controller
    {
        AppDbContext db;

        public FacebookNotificationController(AppDbContext _db)
        {
            db = _db;
        }

        public IActionResult ListOfMessage()
        {
            var list_notification = db.Messages.ToList();
            return Json(list_notification);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(Message model)
        {
            db.Add<Message>(model);
            db.SaveChanges();
            return RedirectToAction("Index", "FacebookNotification");
        }
    }
}