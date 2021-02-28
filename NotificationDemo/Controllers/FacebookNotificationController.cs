using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotificationDemo.Data;

namespace NotificationDemo.Controllers
{
    public class FacebookNotificationController : Controller
    {
        AppDbContext db;

        public FacebookNotificationController(AppDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }
    }
}