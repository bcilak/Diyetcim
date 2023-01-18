using BitirmeDeneme.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BitirmeDeneme.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext context;
        public HomeController(DataContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        

        public IActionResult Contact()
        {
          

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult Message()
        {
            ViewData[""] = "Your application description page.";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult AddRequest()
        {
            return View();
        }          
        [HttpPost]
        public IActionResult AddRequest(Request model)
        {
            context.Requests.Add(model);
            context.SaveChanges();

            return View("Thanks",model);
        }
        public IActionResult Kayit()
        {
            
            return View();
        }
        public IActionResult KayitDanisan()
        {
            return View();
        }
        public IActionResult KayitDoktor(Doktor doktor)
        {

            context.Doktor.Add(doktor);
            
            context.SaveChanges();
            context.Remove(doktor);

            return View();
        }
        public IActionResult Giris()
        {

            return View();
        }
        public IActionResult Plan()
        {

            return View();
        }
        
        public IActionResult Rezervasyon()
        {

            return View();

        }
        public IActionResult Doktor1()
        {   
            return View(context.Doktor);
        }

    }
}
