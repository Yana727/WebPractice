using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebPractice.Models;

namespace WebPractice.Controllers
{
    public class SubscribeController : Controller 
    {
       [Route ("/subscribe")]
       public IActionResult Index()  //so it returns a message on the page 
       {
         return View();  
       } 
         [HttpPost]
         public IActionResult Index(string subscribe) //must match
         {
          Console.WriteLine("got submit" + subscribe); // must match
          ViewData["Subscribe"] = subscribe; 
          return View(); 

         }
    }
}
