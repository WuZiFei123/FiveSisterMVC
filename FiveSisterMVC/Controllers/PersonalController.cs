using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveSisterMVC.Controllers
{
    public class PersonalController : Controller
    {
        public ActionResult SingePersonalCenter(int userInfoId=0)
        {
            ViewBag.userInfoId = userInfoId;
            return View();
        }
        public ActionResult Place()
        {
            return View();
        }
    }
}
