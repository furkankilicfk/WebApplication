using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Contoller
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {

            Product p = new Product();      //Controllerdan Model'a gittim veriyi kullanıyorum

            //veri üretildi...
                                                //farklı yol
            //ViewResult result = View();      // ilgili action ismiyle birebir aynı olan view ı tetikler
            //ViewResult result = View("ahmet");        belirtilen view ismindeki view dosyasını render eder (ahmet.cshtml)  //render edeceğim viewi burada tetiklemem lazım
            //return result;
                                            //ÖNCE BURASI
            return View();                  //İlgili dizine kariılık gelen GetProducts ismindeki View'i tetikleyecek, render edecek ve sonuç olarak elde ettiği viewreult'u geriye return edecek (client'a response etme)
                                            //ilgili action isteği karşılıyor, kendi viewini render ettirip sonucu bize döndürüyor tarayıcı yorumlayıp bana gösteriyor. 
        }                                   //View fonk bu actiona ait view(.cshtml) dosyasını tetikleyecek fonsiyondur
    }
}
