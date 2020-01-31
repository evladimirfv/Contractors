using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Contractors.Models;
using Microsoft.AspNetCore.Authorization;  


namespace Contractors.Controllers
{
     [Authorize]  
    public class ServiciosController : Controller
    {
        private readonly ILogger<ServiciosController> _logger;

        public ServiciosController(ILogger<ServiciosController> logger)
        {
            _logger = logger;
        }

      

        public IActionResult Servicios()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
