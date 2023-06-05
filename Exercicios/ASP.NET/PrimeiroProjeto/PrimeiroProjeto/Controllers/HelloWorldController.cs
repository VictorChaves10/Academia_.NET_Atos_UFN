using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace PrimeiroProjeto.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
          
        }

        public IActionResult Welcome(string nome, int numTime = 1)
        {
            //return "Estou no método Welcome do Hello World";

            ViewData["Message"] = "Oie" + nome;
            ViewData["NumTimes"] = numTime;
            return View();           

        }

        public string Oi()
        {
            return "Hello";
        }
    }
}
