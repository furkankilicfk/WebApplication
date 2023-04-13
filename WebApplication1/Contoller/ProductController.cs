using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Contoller
{
    public class ProductController : Controller
    {
        //public IActionResult GetProducts()
        //{

        //    Product p = new Product();      //Controllerdan Model'a gittim veriyi kullanıyorum

        //    //veri üretildi...
        //                                        //farklı yol
        //    //ViewResult result = View();      // ilgili action ismiyle birebir aynı olan view ı tetikler
        //    //ViewResult result = View("ahmet");        belirtilen view ismindeki view dosyasını render eder (ahmet.cshtml)  //render edeceğim viewi burada tetiklemem lazım
        //    //return result;
        //                                    //ÖNCE BURASI
        //    return View();                  //İlgili dizine karşılık gelen GetProducts ismindeki View'i tetikleyecek, render edecek ve sonuç olarak elde ettiği viewreult'u geriye return edecek (client'a response etme)
        //                                    //ilgili action isteği karşılıyor, kendi viewini render ettirip sonucu bize döndürüyor tarayıcı yorumlayıp bana gösteriyor. 
        //}                                   //View fonk bu actiona ait view(.cshtml) dosyasını tetikleyecek fonsiyondur



        //PartialViewResult'ın viewResult'tan farkı pw sayfanın sadece bir bölümü(parçası) için action döndürür, tüm sayfayı döndürmez -
        //client tabanlı Ajax isteklerinde kullanılır.
        //ViewResult, _ViewStart.cshtml dosyasını baz alır. Lakin PartialViewResult ilgili dosyayı baz almadan render edilir.
        //_ViewStart.cshtml tüm viewların başlangıç dosyasıdır. Bu dosya tüm viewler tarafından render edilmeden önce render edilir. Haliyle ViewResult bu dosyayı baz alır.


        //public JsonResult GetProducts()
        //{
        //    JsonResult result = Json(new Product        //JsonResult json nesnesi istiyor. Hangi değeri json formatına dönüştüreceksek onu benden object olarak istiyor. sonuç olarak jsonresult döndüreceğini bildiriyor.
        //    {
        //        Id = 5,
        //        ProductName = "Terlik",
        //        Quantity = 20,
        //    });

        //    return result;      //ilgili jsona dönüştürmüş oldum || client değeri json olarak elde edecek || Genelde json'ı client tabanlı alıp clientta işleriz // response headerında json olarak döndüğünü gösteriyor. o yüzden client tabanlı alırız.
        //}

        //public EmptyResult GetProducts()        // Boş değer döndürmek istediğimiz zaman || Response var Result yok
        //{
        //    return new EmptyResult(); 
        //}

        //public void GetProducts()     // Empty'nin muadilidir
        //{
        //    //
        //}

        //public ContentResult GetProducts()          //Sayfada metinsel değer döndürmek istediğimizde || Sayfa formatı html değil text olarak gelir 
        //{
        //    ContentResult result = Content("abcde");        //Client tabanlı tercih

        //    return result;
        //}

        public ActionResult GetProducts()           //İstediğin türü döndürebildiğin yapıdır. Genellikle (aşağıdaki gibi) 
        {
            if (true)
            {
                return Json(new object());          //şart durumunu kontrol edersin
            }
            else if (false)
            {
                return Content("abcde");            //Farklı değerlerin döndürebilmek için ortaj tür sağlayan result türüdür
            }
            return View();                          //IAction interfacidir
        }


        //Controller içerisindeki actionlar gerekli noktaları tetikler ama iş yapmaz. actionlar iş yapmak için değil iş yapanları çağırmak için vardır.
        //iş mantığını üstlenmemeli onlara gerekli taleplerde bulunmalıdır. 
        //sadece iş mantığğı yürüten bir şey illa yazmak istiyorsan gelen requestleri engellemelisin [NonAction] -- iş mantığı, alogitma batındırır.
        //Sistemdeki tüm Controllerlar dışarıdan istek alabilmektedirler. Hem controller tanımlayıp hem de dışarıdan istek almasını istemiyorsak [NonController]. Sıradan bir sınıf olacak.

    }
}
