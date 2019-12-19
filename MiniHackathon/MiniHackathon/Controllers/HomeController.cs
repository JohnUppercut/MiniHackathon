using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniHackathon.Models;

namespace MiniHackathon.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PersonalAccountClient()
        {
            return View();
        }
        public IActionResult PersonalAccountDoctor()
        {
            return View();
        }

        public IActionResult AppointmentToTheDoctor()
        {
            return View();
        }

        public IActionResult AboutService()
        {
            return View();
        }

        public IActionResult ListOfDoctors()
        {
            return View();
        }
        public IActionResult ItemListOfDoctor()
        {
            return View();
        }
        public IActionResult PatientApplications()
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
