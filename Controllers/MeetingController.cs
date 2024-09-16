using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            if (ModelState.IsValid)
            {
                Repository.AddUser(model);
                ViewBag.UserCount = Repository.Users.Where(u => u.WillAttend == true).Count();
                return View("Thanks", model);
            } 
            return View(model);
        }

        public IActionResult List()
        {
            return View(Repository.Users);
        }
    }
}