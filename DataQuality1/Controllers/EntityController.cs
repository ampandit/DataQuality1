using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataQuality1.Controllers
{
    public class EntityController : Controller
    {
        // GET: Entity
        public ActionResult Result()
        {
            // get model from database
            return View();
        }
    }
}