using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using testProject.DAL;
using testProject.Entity;
using testProject.Models;

namespace testProject.Controllers
{
    public class HomeController : Controller
    {
        DBContext db = null;
        private readonly ILogger<HomeController> _logger;

      

        public HomeController(DBContext data)
        {
            this.db = data;
        }
        public IActionResult Index()
        {
            //IDBIntializer.Initialize(this.db);\
            var data = this.db.Countries;
            ViewBag.countries = data.OrderBy(d => d.name).Skip((2 - 1) * 10).Take(10).ToList();
            return View();
        }

        public List<Country> getData(int pagenumber)
        {
            var data = this.db.Countries;
            return data.OrderBy(d => d.name).Skip((pagenumber - 1) * 10).Take(10).ToList();
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
        /*https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-3.1&tabs=visual-studio*/
    }
}
