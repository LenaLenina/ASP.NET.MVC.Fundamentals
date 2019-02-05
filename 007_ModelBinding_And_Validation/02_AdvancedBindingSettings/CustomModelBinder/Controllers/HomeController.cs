using CustomModelBinder.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomModelBinder.Controllers
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
        public ActionResult Index(MyModel model)
        {
            Debug.WriteLine("model.Prop1 = " + model.Prop1);
            Debug.WriteLine("model.Prop2 = " + model.Prop2);

            return View();
        }

    }
}
