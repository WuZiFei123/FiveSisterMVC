using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveSisterMVC.Controllers
{
    public class GoodsInfoController : Controller
    {
        public IActionResult AddGoods()
        {
            return View();
        }
    }
}
