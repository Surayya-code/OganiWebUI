using Microsoft.AspNetCore.Mvc;
using Ogani_WebUI.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ogani_WebUI.Controllers
{
    public class HomeController : Controller
    {
        readonly OganiDbContext db;
        public HomeController(OganiDbContext db){
           this.db = db;
        }
        public IActionResult Index()
        {
            var categories = db.Categories.ToList();
            return View(categories);
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
