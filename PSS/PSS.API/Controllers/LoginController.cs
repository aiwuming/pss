using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PSS.API.Models;

namespace PSS.API.Controllers
{
    public class LoginController : ApiController
    {
        BarneauEntities1 db = new BarneauEntities1();
        public IHttpActionResult PostLogin(dynamic obj)
        {
            string Uname = obj.Uname;
            string Upwd = obj.Upwd;
            User u = db.User.SingleOrDefault(s => s.Uname == Uname && s.Upwd == Upwd);
            if (u != null)
            {
                //将对象存入Session
                System.Web.HttpContext.Current.Session["user"] = u;
            }
            return Ok(u != null);
        }
        public IHttpActionResult Get()
        {
            return Ok(System.Web.HttpContext.Current.Session["user"]);
        }
        public void Options() { }
    }
}
