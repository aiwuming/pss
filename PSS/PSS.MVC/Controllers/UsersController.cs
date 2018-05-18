using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSS.MVC.Controllers
{
    public class UsersController : Controller
    {
        //用户管理
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult 登录()
        {
            return View();
        }
        public ActionResult 用户资料()
        {
            return View();
        }
        public ActionResult 用户修改()
        {
            return View();
        }
    }
}