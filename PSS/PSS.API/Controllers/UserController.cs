using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PSS.API.Models;

namespace PSS.API.Controllers
{
    public class UserController : ApiController
    {
        BarneauEntities1 db = new BarneauEntities1();
        public IHttpActionResult Post(User u)
        {
            db.User.Add(u);
            return Ok(db.SaveChanges());
        }
        public IHttpActionResult Get(string Uname)
        {
            User u = db.User.SingleOrDefault(s => s.Uname == Uname);
            return Ok(u != null);
        }
    }
}
