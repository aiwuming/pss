using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSS.MVC.Controllers
{
    public class BasicDataController : Controller
    {
        //基础数据
        // GET: BasicData                                                                                                                                                                          
        public ActionResult Index()
        {
            return View();
        }
        #region 基础页面
        public ActionResult 商品分类()
        {
            return View();
        }
        public ActionResult 仓库设置()
        {
            return View();
        }
        public ActionResult 商品资料()
        {
            return View();
        }
        public ActionResult 供应商()
        {
            return View();
        }
        public ActionResult 客户资料()
        {
            return View();
        }
        public ActionResult 员工设置()
        {
            return View();
        }
        #endregion

        #region 所有添加
        public ActionResult 添加仓库设置()
        {
            return View();
        }

        public ActionResult 添加供应商()
        {
            return View();
        }
        public ActionResult 添加客户资料()
        {
            return View();
        }

        public ActionResult 添加商品分类()
        {
            return View();
        }

        public ActionResult 添加商品资料()
        {
            return View();
        }

        public ActionResult 添加员工设置()
        {
            return View();
        }
        #endregion

        #region 所有修改
        public ActionResult 修改仓库设置()
        {
            return View();
        }

        public ActionResult 修改供应商()
        {
            return View();
        }
        public ActionResult 修改客户资料()
        {
            return View();
        }

        public ActionResult 修改商品分类()
        {
            return View();
        }

        public ActionResult 修改商品资料()
        {
            return View();
        }

        public ActionResult 修改员工设置()
        {
            return View();
        }
        #endregion
    }
}