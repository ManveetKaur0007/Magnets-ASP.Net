using System;
using System.ComponentModel.DataAnnotations;

namespace ManveetKaurMagnets.Models
{
    public class Magnets
    {
        public int Id { get; set; } // this is the primary key! unquie identifier!
        public string Shape { get; set; }
        public string Colour { get; set;}
        public string Type { get; set; }
        public int Power { get; set; }
        public string CustomerReview { get; set; }

    }
}
