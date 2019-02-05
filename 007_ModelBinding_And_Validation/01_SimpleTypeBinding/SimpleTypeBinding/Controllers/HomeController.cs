using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleTypeBinding.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        // Связыватель модели - объект который производит поиск значений в запросе в соответствии с именами параметров метода действия.
        // Связыватель модели по умолчанию производит поиск значений в следующем порядке:
        // 1) Request.Form
        // 2) RouteData.Values
        // 3) Request.QueryString
        // 4) Request.Files

        public ActionResult Action1(int id)
        {
            ViewBag.Message = "Метод действия Action1(int id)";
            ViewBag.Data = id;

            return View("ActionView");
        }

        public ActionResult Action2(int id = 1)
        {
            ViewBag.Message = "Метод действия Action2(int id = 1). При отсутствии значения для параметра id будет использоваться значение 1";
            ViewBag.Data = id;

            return View("ActionView");
        }

        public ActionResult Action3(int? id)
        {
            ViewBag.Message = "Метод действия Action3(int? id). При отсутствии значения для параметра id будет использоваться значение null";
            ViewBag.Data = id;

            return View("ActionView");
        }
    }
}