﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebPractice.Models;

namespace WebPractice.Controllers
{
    public class ApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

         public string First()// for your URL
         {
             return ("hello world!"); // since we are in the "home", type in localhost:5000/home/first
         }


       
    }
}