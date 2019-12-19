using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniHackathon.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FIO { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Sex { get; set; }
        public DateTime DayOfBirth { get; set; }
        public string Email { get; set; }
    }
}
