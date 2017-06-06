using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMathService.MathMVCService;

namespace MVCMathService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add(int param1, int param2)
        {
            CulcServiceClient client = new CulcServiceClient();
            ViewBag.result = client.Add(param1, param2).ToString();
            return View();
        }

    }
}