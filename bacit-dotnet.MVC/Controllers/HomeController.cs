﻿using bacit_dotnet.MVC.DataAccess;
using bacit_dotnet.MVC.Models;
using bacit_dotnet.MVC.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace bacit_dotnet.MVC.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]

        public IActionResult Produkter()
        {
            return View();
        }
        public IActionResult Index()
        {
            _logger.LogInformation("Index method called");

            var model = new RazorViewModel
            {
            };
            return View("Index", model);
        }
    }
}