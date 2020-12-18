using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveSisterMVC.Controllers
{
    public class PersonalController : Controller
    {
        public ActionResult SingePersonalCenter(int userInfoId = 1)
        {
            ViewBag.userInfoId = userInfoId;
            return View();
        }
        public ActionResult Place(int userInfoId = 1)
        {
            ViewBag.userInfoId = userInfoId;
            return View();
        }
        public ActionResult ModifyPlace(int addressInfoId, int posstionInfoPIdOut, int posstionInfoCIdOut, int posstionInfoDIdOut, string addressInfoPeople, string addressInfoPhone, string addressInfoName,int addressInfoState)
        {
            ViewBag.addressInfoId = addressInfoId;
            ViewBag.posstionInfoPIdOut = posstionInfoPIdOut;
            ViewBag.posstionInfoCIdOut = posstionInfoCIdOut;
            ViewBag.posstionInfoDIdOut = posstionInfoDIdOut;
            ViewBag.addressInfoPeople = addressInfoPeople;
            ViewBag.addressInfoPhone = addressInfoPhone;
            ViewBag.addressInfoName = addressInfoName;
            ViewBag.addressInfoState = addressInfoState;
            return View();
        }
    }
}
