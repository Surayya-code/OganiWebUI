using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ogani_WebUI.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult ShoppingCards()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        
    }
}
