using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ManveetKaurMagnets.Models
{
    public class MagnetsColourViewModel
    {
        public List<Magnets> Magnets { get; set; }
        public SelectList Colour { get; set; }
        public string MagnetsColour { get; set; }
        public string SearchString { get; set; }
    }
}




