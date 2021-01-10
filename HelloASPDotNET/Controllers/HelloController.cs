using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNET.Controllers
{
    //[Route("/helloworld")]
    public class HelloController : Controller
    {
        //GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            //string html = "<form method = 'post' action= '/hello/welcome'>" +
           
            //"<label> Language: " +
            //"<select name = 'language'>" +
            //"<option value = '1' selected>English</option>" +
            //"<option value = '2' selected>French</option>" +
            //"<option value = '3' selected>Cantonese</option>" +
            //"<option value = '4' selected>Japanese</option>" +
            //"<option value = '5' selected>Mandarin</option>" +
            //"</select>" + "</label>" + 
            return View();
        }

        //GET: /hello/welcome
        //[HttpGet]
        //[Route("/helloworld/welcome/{name?}")]

        [HttpGet("welcome/{name?}")]

        [HttpPost]
        [Route("/hello")]
        //[Route("hello/welcome")] 
            //{value?}")]
        public IActionResult Welcome(string name = "World") //, string language)
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }

        //public static CreateMessage(string name, string value)
        //{
        //    if (value == "1")
        //    {
        //        return "Hello, " + name + "!";
        //    }
        //    else if (value == "2")
        //    {
        //        return "Bonjour, " + name + "!";
        //    }
        //    else if (value == "3")
        //    {
        //        return "Lay ho, " + name + "!";
        //    }
        //    else if (value == "4")
        //    {
        //        return "Konnichiwa, " + name + "!";
        //    }
        //    else if (value == "5")
        //    {
        //        return "Ni hao, " + name + "!";
        //    }
        //}

    }
}
