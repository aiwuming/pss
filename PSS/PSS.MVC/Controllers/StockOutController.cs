using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSS.MVC.Controllers
{
    public class StockOutController : Controller
    {
        //出库管理
        // GET: StockOut
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult 出库订单()
        {
            return View();
        }
        public ActionResult 签收订单()
        {
            return View();
        }
        //申请退货
        public ActionResult 退货处理()
        {
            return View();
        }
        //处理退货
        public ActionResult 处理退货()
        {
            return View();
        }
    }
}