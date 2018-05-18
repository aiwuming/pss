using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSS.MVC.Controllers
{
    public class StockController : Controller
    {
        //入库管理
        // GET: Stock
        //首页
        public ActionResult Index()
        {
            return View();
        }
        //入库订单
        public ActionResult StockOrder()
        {
            return View();
        }
        //当前库存
        public ActionResult TheCurrentInventory()
        {
            return View();
        }
        //退货处理
        public ActionResult ReturnGoodsHandling()
        {
            return View();
        }
        //收款
        public ActionResult Gathering()
        {
            return View();
        }
    }
}