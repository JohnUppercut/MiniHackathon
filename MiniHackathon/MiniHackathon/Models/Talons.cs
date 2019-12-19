using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniHackathon.Models
{
    public class Talons
    {
        public int Talon_ID { get; set; }
        public int Doctor_IDof { get; set; }
        public int UserPacient_IDof { get; set; }
        public DateTime Time { get; set; }
        public float Cost { get; set; }
        public string Symptoms { get; set; }
        public string Purpose { get; set; }
    }
}
