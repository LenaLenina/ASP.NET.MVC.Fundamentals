using BindingWithPrefix.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BindingWithPrefix.Controllers
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
        public ActionResult Index(MyModel model1, MyModel model2)
        {
            Debug.WriteLine("model1.Prop1 = " + model1.Prop1);
            Debug.WriteLine("model1.Prop2 = " + model1.Prop2);

            Debug.WriteLine("model2.Prop1 = " + model2.Prop1);
            Debug.WriteLine("model2.Prop2 = " + model2.Prop2);

            return View();
        }

    }
}
