﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace COVID19Ninjas.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }


        [HttpGet]
        public void updateTrnx(string refid)
        {
           
        }
    }
}