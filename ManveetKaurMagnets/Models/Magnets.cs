using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManveetKaurMagnets.Models
{
    public class Magnets
    {
        public int Id { get; set; } // this is the primary key! unquie identifier!
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(20)]
        public string Shape { get; set; }
        public string Colour { get; set;}
        public string Type { get; set; }
        public int Power { get; set; }

        [Display(Name = "Customer Review")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(20)]
        public string CustomerReview { get; set; }

    }


}

