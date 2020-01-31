using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Contractors.Models;
using Microsoft.AspNetCore.Authorization;



using System.Data;
// dotnet add package Microsoft.EntityFrameworkCore.SqlServer
// dotnet add package Microsoft.EntityFrameworkCore.MySql

// dotnet add package MySql.Data.EntityFrameworkCore --version 6.10.8     8.0.18
// https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework-core-example.html

using MySql.Data;
using MySql.Data.Entity;

using System.Text;
using Microsoft.EntityFrameworkCore;

// using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
 // using System.Linq;





namespace Contractors.Controllers
{
     [Authorize]
    public class OrdenDeTrabajoController : Controller
    {
        private readonly ILogger<OrdenDeTrabajoController> _logger;

        public OrdenDeTrabajoController(ILogger<OrdenDeTrabajoController> logger)
        {
            _logger = logger;
        }



        public IActionResult OrdenDeTrabajo()
        {
            return View();
        }

        // public IActionResult OrdenDeTrabajo(OrdenDeTrabajo ot)
        // {
        //     return View(ot);
        // }


       


        [HttpPost]
        public IActionResult CreateEdit(int Id = 0)
        {

            if (ModelState.IsValid)
            {

                  
                    
                   
                   
                  

                    // return RedirectToAction("ViewAll");
            }

          


             return RedirectToAction("ListaDeOrdenesDeTrabajo");

        }



        public ActionResult ListaDeOrdenesDeTrabajo()
        {
            
           ContractorsContext context = HttpContext.RequestServices.GetService(typeof(Contractors.Models.ContractorsContext)) as ContractorsContext;


           List<Profesional> p = context.GetAllProfesional();

           
           
            return View( new List<Profesional>());   // tasks param
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
