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
using System.Text;

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
        public string GetUser(string retype, string actionname, object obj = null)
        {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("http://localhost:50519/api/GoodsUserInfo/");
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
        /// 三次握手
        /// </summary>
        /// <param name="retype"></param>
        /// <param name="actionname"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string GetApi(string retype, string actionname, object obj = null)
        {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("http://localhost:50519/api/ClothesType/");
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
            //string StrUser = GetUser("get", "GetUserInfoById?Id=" + UserId);
            //UserInfo u = JsonConvert.DeserializeObject<UserInfo>(StrUser);
            //ViewBag.User = u;
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
        /// <summary>
        /// 商品详情
        /// </summary>
        /// <returns></returns>
        public IActionResult GoodsLook(int GoodsId=0)
        {
            ViewBag.GoodsId = GoodsId;
            return View();
        }
        /// <summary>
        /// 获取优惠券
        /// </summary>
        /// <returns></returns>
        public IActionResult DisCount()
        {
            return View();
        }
        /// <summary>
        /// 过期优惠券
        /// </summary>
        /// <returns></returns>
        public IActionResult DisCountEndOver()
        {
            return View();
        }
        /// <summary>
        /// 订单收货管理
        /// </summary>
        /// <returns></returns>
        public IActionResult OrderMessage()
        {
            return View();
        }
        /// <summary>
        /// 订单付款管理
        /// </summary>
        /// <returns></returns>
        public IActionResult OrderPayMoney()
        {
            return View();
        }
        /// <summary>
        /// 订单评价管理
        /// </summary>
        /// <returns></returns>
        public IActionResult OrderRemark()
        {
            return View();
        }
        /// <summary>
        /// 订单待发货管理
        /// </summary>
        /// <returns></returns>
        public IActionResult OrderFh()
        {
            return View();
        }
        /// <summary>
        /// 优惠券管理
        /// </summary>
        /// <returns></returns>
        public IActionResult DisMessage()
        {
            return View();
        }
        public IActionResult OrderCommit()
        {
            return View();
        }
    }
}
