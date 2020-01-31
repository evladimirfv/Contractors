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
    public class ProfesionalController : Controller
    {
        private readonly ILogger<ProfesionalController> _logger;

        public ProfesionalController(ILogger<ProfesionalController> logger)
        {
            _logger = logger;
        }

      

        public IActionResult Profesional()
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
