using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdvancedBindingSettings.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string data)
        {
            // Данные для параметра data будут получены из cookie набора с именем data
            ViewBag.Data = "Данные прочитаные из cookie " + data;
            return View();
        }

    }
}
