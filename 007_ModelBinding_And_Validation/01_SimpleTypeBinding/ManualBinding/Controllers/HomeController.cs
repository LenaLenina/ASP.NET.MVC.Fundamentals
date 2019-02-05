using ManualBinding.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManualBinding.Controllers
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
        public ActionResult SetData()
        {
            try
            {
                MyModel model = new MyModel();
                UpdateModel(model);

                Debug.WriteLine("Prop1 = " + model.Prop1);
                Debug.WriteLine("Prop2 = " + model.Prop2);
            }
            catch
            {
                Debug.WriteLine("ERROR!");
            }

            return View("Index");
        }

    }
}
