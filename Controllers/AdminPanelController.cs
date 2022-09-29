﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Controllers
{
    public class AdminPanelController : Controller
    {
        public AdminPanelController()
        {

        }
        public IActionResult Index()
        {
            var role = HttpContext.Session.GetString("Role");
            if (role.Equals("admin"))
            {
                return View();
            }
            return RedirectToAction("Unauthorized", "ErrorPage");
        }
    }
}
