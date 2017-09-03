using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebPractice.Models;

namespace WebPractice.Controllers
{
    public class APIController : Controller //Why can't this be API controller? wants to be HomeController
    {
        protected APIController() //Why empty? 
        {
        }

        public IActionResult Api()
        {
            var person = new ApiModel
            {

                Name = "Yana",
                Height = 70,
                Color = "Blonde"

            };
            return Json(person);
        }
    }
}