﻿using Microsoft.AspNetCore.Mvc;

namespace EcoTech.MVC.Controllers
{
    public class ContactController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
