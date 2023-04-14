using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using WebApplication1.Models;

namespace WebApplication1.Contoller
{
    public class CityController : Controller
    {
        public IActionResult Index()
        {

            var cities = new List<City>
            {
                new City { Id = 1, CityName = "Paris", Population = 100000 },
                new City { Id = 2, CityName = "Munchen", Population = 60000 },
                new City { Id = 2, CityName = "Istanbul", Population = 5000000 },


            };
            //Model Bazlı Veri Gönderimi
            //return View(cities); //göndereceğimiz datayı da bildiriyoruz 


            //ViewBag
            //View'e gönderilecek/taşınacak datayı dynamic şekilde tanımlanan bir değişkenle taşımamızı sağlayan bir veri taşıma kontrolüdür.

            //ViewBag.data = cities;          //Dynamic değişkene elimdeki datayı verdim  ||  view'de erişilebilir hale geldi

            //return View();

            //ViewData 
            //ViewBag'de old gibi actiondaki datayı view'e taşımamızı sağlayan bir kontroldür. Viewdata ilgili datayı boxing ederek taşır

            ViewData["data"] = cities;

            return View();
        }
    }
}
