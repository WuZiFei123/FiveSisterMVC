using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FiveSisterMVC.Controllers
{
    public class ShopCarController : Controller
    {
        public IActionResult SingShopCar()
        {
            return View();
        }
    }
}