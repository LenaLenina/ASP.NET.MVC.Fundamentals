using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArrayBinding.Controllers
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
        public ActionResult Index(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Debug.WriteLine(numbers[i]); 
            }

            return View();
        }

    }
}
