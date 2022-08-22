using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        // 
        // GET: /HelloWorld/

        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        //public string Welcome(string name, int id=1)
        //{
        //    //return "This is the Welcome action method...";
        //    //return HtmlEncoder.Default.Encode($"Hello my name is {name}, NumTimes is: {numTimes}");
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {id}");
        //}
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
