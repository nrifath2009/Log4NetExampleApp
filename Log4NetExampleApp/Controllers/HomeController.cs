using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Log4NetExampleApp.Controllers
{
    public class HomeController : Controller
    {
        ILog _log = log4net.LogManager.GetLogger(typeof(HomeController));
        public ActionResult Index()
        {
            _log.Debug("This is debug");
            _log.Info("This is info");
            _log.Error("This is error");
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
    }
}