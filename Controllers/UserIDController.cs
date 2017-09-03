using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebPractice.Models;

namespace WebPractice.Controllers

{
    public class UserIDController : Controller 
    {
        [Route ("/user/{ID}")]

       public IActionResult UserID()  //so it returns a message on the page 
       {
         return View();  
       }
    }
}
