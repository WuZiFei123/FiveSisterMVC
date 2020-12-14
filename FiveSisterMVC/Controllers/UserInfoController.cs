using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FiveSisterMVC.Models;
using System.Net.Http;
using Newtonsoft.Json;
namespace FiveSisterMVC.Controllers
{
    public class UserInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Zhu()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
    
    }
}
