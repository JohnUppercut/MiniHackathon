using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniHackathon.Models
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public User ThisUser { get; set; }
        public string Speciality { get; set; }
        public string Hospital { get; set; }
        public string Position { get; set; }
        public double Rating { get; set; }
        public string Position { get; set; }
        public Hospital ThisHospital { get; set; }
    }
}
