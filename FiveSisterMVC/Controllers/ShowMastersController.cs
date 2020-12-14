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
    public class ShowMastersController : Controller
    {
        /// <summary>
        /// 三次握手
        /// </summary>
        /// <param name="retype"></param>
        /// <param name="actionname"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string GetApi(string retype, string actionname, object obj = null)
        {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("http://localhost:50519/api/FiveSister/");
            Task<HttpResponseMessage> task = null;
            switch (retype)
            {
                case "get":
                    task = hc.GetAsync(actionname);
                    break;
                case "post":
                    task = hc.PostAsJsonAsync(actionname, obj);
                    break;
                case "put":
                    task = hc.PutAsJsonAsync(actionname, obj);
                    break;
                case "delete":
                    task = hc.DeleteAsync(actionname);
                    break;
            }
            if (task != null)
            {
                if (task.Result.IsSuccessStatusCode)
                {
                    var studata = task.Result.Content.ReadAsStringAsync();
                    return studata.Result;
                }
            }
            return "";
        }
        /// <summary>
        /// 显示主页面
        /// </summary>
        /// <returns></returns>
        public IActionResult ShowMaster()
        {
            string list = GetApi("get", "GetClothesTypes");
            List<ClothesType> li = JsonConvert.DeserializeObject<List<ClothesType>>(list);
            ViewBag.Alist = li;
            ViewBag.Father = li.Where(l=>l.ClothesTypePid==0).ToList();
            return View();
        }
        /// <summary>
        /// 商品查询页面
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public IActionResult SerchGoods(string Name="",int Flag=0)
        {
            ViewBag.Name = Name;
            ViewBag.Flag = Flag;
            return View();
        }
        /// <summary>
        /// 商品收藏页面
        /// </summary>
        /// <returns></returns>
        public IActionResult GoodsAddCollect()
        {
            return View();
        }

        public IActionResult GoodsLook()
        {
            return View();
        }
    }
}
