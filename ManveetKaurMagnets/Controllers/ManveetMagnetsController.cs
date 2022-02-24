using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ManveetKaurMagnets.Controllers
{
    public class ManveetMagnetsController : Controller
    {
        // 
        // GET: /ManveetMagnets/

        //public string Index()    // this will only return Index of type string
        public IActionResult Index()
        {
            //return "This is my default action...";
            return View();
        }

        // 
        // GET: /ManveetMagnets/Welcome/ 

        /*public string Welcome(string name, int ID = 1)
        {
            //return "This is the Welcome action method...";
            return HtmlEncoder.Default.Encode($"Hello {name}, ID {ID}");
        }*/
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}