using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniHackathon.Models
{
    public class User:IdentityUser
    {
        public int UserID { get; set; }
        public string Login { get; set; }
        public string HashPass { get; set; }
        public string FIO { get; set; }
    }
}
