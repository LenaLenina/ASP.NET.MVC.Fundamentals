using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03_JsonResultSample.Controllers
{
    public class DataController : Controller
    {
        //
        // GET: /Data/

        [HttpGet] // атрибут устанавливает ограничение на метод Action1 и позволяет выполнять его только при GET запросе
        public ActionResult Action1()
        {
            var product = new
            {
                Name = "Item 1",
                Price = 10,
                Description = "Dummy Text ....",
            };

            // По умолчанию MVC Framework не будет возвращать JSON в ответ на GET запрос по причнинам безопасности.
            // Возвращать в ответ на GET запрос JSON безопасно если в ответе не содержатся чувствительные данные.
            // http://haacked.com/archive/2009/06/25/json-hijacking.aspx/

            return Json(product, JsonRequestBehavior.AllowGet);
        }

        [HttpPost] // атрибут устанавливает ограничение на метод Action2 и позволяет выполнять его только при POST запросе
        public ActionResult Action2()
        {
            var product = new
            {
                Name = "Item 1",
                Price = 10,
                Description = "Dummy Text ....",
            };

            return Json(product);
        }

        [HttpPost] 
        public ActionResult Action3()
        {
            List<Product> products = new List<Product>(){
                new Product(){Name="Item 1",Price = 10, Description="Dummy text1"},
                new Product(){Name="Item 2",Price = 20, Description="Dummy text2"},
                new Product(){Name="Item 3",Price = 30, Description="Dummy text3"},
                new Product(){Name="Item 4",Price = 40, Description="Dummy text4"},
                new Product(){Name="Item 5",Price = 50, Description="Dummy text5"},
                new Product(){Name="Item 6",Price = 60, Description="Dummy text6"},
            };

            return Json(products);
        }
    }

    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
