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
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul Abc Kongre Merkezi",
                Date = new DateTime(2024, 09, 24, 20, 0, 0),
                NumberOfPeople = Repository.Users.Where(u => u.WillAttend == true).Count()
            };
            return View(meetingInfo);
        }
    }
}