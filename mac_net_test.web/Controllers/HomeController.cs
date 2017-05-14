using mac_net_test.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace mac_net_test.web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            var model = new List<test_model>();
            for (int i = 1; i <= 100; i++)
            {
                model.Add(new test_model
                {
                    id = i,
                    uid = "uid_" + i,
                    pwd = "pwd_" + i
                });
            }
            return View(model);
        }
    }
}
