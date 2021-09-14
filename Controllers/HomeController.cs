using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC2.Models;

namespace PC2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Principal");
        }

        public IActionResult Principal()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
         public IActionResult Registro(Registro objReg){
            Console.WriteLine(objReg.Nombres);
            Console.WriteLine(objReg.ApellidoPat);
            Console.WriteLine(objReg.ApellidoMat);
            Console.WriteLine(objReg.Mascota);
            Console.WriteLine(objReg.Descripcion);
            Console.WriteLine(objReg.Telefono);
            Console.WriteLine(objReg.Distrito);
            Console.WriteLine(objReg.Direccion);
            return RedirectToAction("RegistroCon");
        }
        
         public IActionResult RegistroCon(){
            return View();
        }




        public IActionResult Privacy()
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
