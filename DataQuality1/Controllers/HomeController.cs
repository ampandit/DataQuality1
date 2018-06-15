using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataQuality1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TableList()
        {
            ViewBag.Message = "List of entities.";
            string json = "C:/Users/AXP6230/Downloads/getEntities_Response.json";
            // TODO: Debug this line
            JObject o1 = JObject.Parse(System.IO.File.ReadAllText(json));
            // dynamic jObj = JsonConvert.DeserializeObject(json);
            foreach (JProperty res in o1.Properties())
            {
                Console.WriteLine(res.Name);
            }
            return View();
        }
    }
}