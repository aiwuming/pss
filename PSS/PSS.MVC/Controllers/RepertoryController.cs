using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSS.MVC.Controllers
{
    public class RepertoryController : Controller
    {//库存管理
        // GET: Repertory
        public ActionResult Index()
        {
            return View();
        }
        //当前库存
        public ActionResult SelectInventory()
        {
            return View();
        }
        //库存报损
        public ActionResult InventoryBreakage()
        {
            return View();
        }
        //库存调动
        public ActionResult InventroyTyansfer()
        {
            return View();
        }
    }
}