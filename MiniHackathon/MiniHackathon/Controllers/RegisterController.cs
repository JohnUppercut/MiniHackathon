using Microsoft.AspNetCore.Mvc;
using MiniHackathon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniHackathon.Controllers
{
    public class RegisterController: Controller
    {
        private DBcontext db;
        public RegisterController(DBcontext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public void Register(User newUser)
        {
            db.Users.Add(newUser);
        }
    }
}
