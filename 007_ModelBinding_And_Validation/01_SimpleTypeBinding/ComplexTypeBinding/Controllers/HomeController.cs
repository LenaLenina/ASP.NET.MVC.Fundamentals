using ComplexTypeBinding.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComplexTypeBinding.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        // В данном случае связыватель модели с помощью рефлексии получает список всех открытых свойств модели (класса MyModel)
        // И осуществляет поиск и установку значений для каждого свойства по очереди, используя стандартный приоритет поиска данных в запросе.
        [HttpPost]
        public ActionResult Index(MyModel model)
        {
            Debug.WriteLine("Prop1 = " + model.Prop1);
            Debug.WriteLine("Prop2 = " + model.Prop2);
            Debug.WriteLine("Prop3 = " + model.Prop3);

            return View();
        }


    }
}
