using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSS.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login() 
        {
            return View();
        }
        //页面在没有创建的时候统一跳转此页面
        public ActionResult Rests() 
        {
            return View();
        }

    }
}