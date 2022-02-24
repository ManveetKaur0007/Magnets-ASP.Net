using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ManveetKaurMagnets.Controllers
{
    public class ManveetMagnetsController : Controller
    {
        // 
        // GET: /ManveetMagnets/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /ManveetMagnets/Welcome/ 

        public string Welcome(string name, int ID = 1)
        {
            //return "This is the Welcome action method...";
            return HtmlEncoder.Default.Encode($"Hello {name}, ID {ID}");
        }
    }
}