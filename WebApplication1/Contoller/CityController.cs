using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Text.Json;
using WebApplication1.Models;

namespace WebApplication1.Contoller
{
    public class CityController : Controller
    {
        //public IActionResult Index()
        //{

        //    var cities = new List<City>
        //    {
        //        new City { Id = 1, CityName = "Paris", Population = 100000 },
        //        new City { Id = 2, CityName = "Munchen", Population = 60000 },
        //        new City { Id = 2, CityName = "Istanbul", Population = 5000000 },


        //    };
        //    //Model Bazlı Veri Gönderimi
        //    //return View(cities); //göndereceğimiz datayı da bildiriyoruz 


        //    //ViewBag
        //    //View'e gönderilecek/taşınacak datayı dynamic şekilde tanımlanan bir değişkenle taşımamızı sağlayan bir veri taşıma kontrolüdür.

        //    //ViewBag.data = cities;          //Dynamic değişkene elimdeki datayı verdim  ||  view'de erişilebilir hale geldi

        //    //return View();

        //    //ViewData 
        //    //ViewBag'de old gibi actiondaki datayı view'e taşımamızı sağlayan bir kontroldür. Viewdata ilgili datayı boxing ederek taşır

        //    //ViewData["data"] = cities;

        //    //return View();

        //    /*TempData["data"] = cities; */     //ViewData'dan farkı olası bir yönlendirmede actionlar arası veri taşımayı sağlamasıdır  || ama complex typeda çalışırken serialize edilmesi lazım.

        //    //ViewBag.x = 5;
        //    //ViewData["x"] = 5;
        //    //TempData["x"] = 5;

        //    string data = JsonSerializer.Serialize(cities);       //ilgili datayı verdim. veriyi serialize etmiş oldum. ilgili string değerine atadım

        //    TempData["cities"] = data;

        //    return RedirectToAction("Index2" , "City");         //Controller ismini istiyor - aynı controllerdayken controller ismin vermeme gerek yok

        //}

        //public IActionResult Index2()
        //{
        //    //var v1 = ViewBag.x;         //null
        //    //var v2 = ViewData["x"];     //null
        //    //var v3 = TempData["x"];     //tutmuş old cookie sayesinde veri taşındı



        //    //serialize edilen kompleks değer buraya string formatta gönderilecek. elde ettikten sonra deserialize işlemine tabi tutmam gerek
        //    var data = TempData["cities"].ToString();       //object olarak geleceğinden dolayı string olarak elde etmemiz lazım

        //    List<City> cities = JsonSerializer.Deserialize<List<City>>(data);  // ilgili string datayı verdim. haliyle ne olarak elde edeceğimi generic olarak bildiriyorum

        //    //List product türünde ilgili değeri tekrardan deserialize edeceğinden dolayı ben ilgili referansta nesneleri tekrardan tutabilmekteyim
        //    //return View();
        //}

        //******************************TUPLE***************
        //public IActionResult Index()
        //{

        //    Product urun = new Product
        //    {
        //        Id = 1,
        //        ProductName = "Apple",
        //        Quantity = 100,
        //    };

        //    City sehir = new City
        //    {
        //        Id = 1,
        //        CityName = "London",
        //        Population = 50000,
        //    };

        //    var cityProduct = (urun, sehir);        //parantezi açıp ilgili değerleri veriyorum->referanslar || tuple nesnesi olarak algılandı

        //    return View(cityProduct);               //artık view tarafından karşılanması gerekecektir.
        //}
        //******************

       
    }
}
