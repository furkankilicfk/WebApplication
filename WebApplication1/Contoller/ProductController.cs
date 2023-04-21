using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
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

        //public IActionResult GetProducts()           //İstediğin türü döndürebildiğin yapıdır. Genellikle (aşağıdaki gibi) 
        //{
        //    if (true)
        //    {
        //        return Json(new object());          //şart durumunu kontrol edersin
        //    }
        //    else if (false)
        //    {
        //        return Content("abcde");            //Farklı değerlerin döndürebilmek için ortaj tür sağlayan result türüdür
        //    }
        //    return View();                          //IAction interfacidir
        //}


        //Controller içerisindeki actionlar gerekli noktaları tetikler ama iş yapmaz. actionlar iş yapmak için değil iş yapanları çağırmak için vardır.
        //iş mantığını üstlenmemeli onlara gerekli taleplerde bulunmalıdır. 
        //sadece iş mantığğı yürüten bir şey illa yazmak istiyorsan gelen requestleri engellemelisin [NonAction] -- iş mantığı, alogitma batındırır.
        //Sistemdeki tüm Controllerlar dışarıdan istek alabilmektedirler. Hem controller tanımlayıp hem de dışarıdan istek almasını istemiyorsak [NonController]. Sıradan bir sınıf olacak.

        //*************************MODEL BINDING***********************
        public IActionResult CreateProduct()    //varsayılan get talebi de ilgili view'in açılması talebidir
        {
            var p = new Product();
            //{
            //    ProductName = "Test",
            //    Quantity = 1,
            //};
            return View(p);
        }


        //[HttpPost]
        //public IActionResult CreateProduct(string txtProductName, string txtQuantity)    //istediğin gibi yakalayabilirsin buradaki dönüşümleri mimari kendi hallediyor
        //{
        //    return View();
        //}

        //Çok fazla veri geldiğinde kullanıcıdan gelecek olan verileri birebir karşılayabilecek bir modele ihtiyacım olur. Product sınıfı gibi. id'yisildik

        [HttpPost]
        public IActionResult CreateProduct(Product p)    //Gelecek olan verileri Product türünden bir nesne ile karşılar
        {                                                //Form'daki name'ler property isimleriyle değiştirilmelidir.
            return View();
        }
        //Form içerisindeki input nesneleri post edildiğinde bu nesnelere karşılık gelen propertyleri barındıran bir nesneyle otomatik olarak bind edilirler.

        /**********************/
        //Get actiobn'ın içinde nesne gönderilmezse post actionı gelecek verileri yeni nesne oluşturup onun içine atar.
        //Ama biz get action'ında nesne gönderirsek user post ettiğinde gelecek olan veriler o nesnenin içine aktarılacaktır.
        //Boş nesne gönderiyoruz nesne dolu olsaydı input doldurduklarımızla gözükürdü

        //userdan veri almak için user'ın sana bir veriyi post etmesi gerekiyor. Bizim karşılayacak fonk.umuz da post

        //IFormCollection ile veri alma yöntemi oldukça basit

        //[HttpPost]
        //public IActionResult CreateProduct(IFormCollection datas)
        //{
        //    var value1 = datas["txtValue1"].ToString();
        //    var value2 = datas["txtValue2"];
        //    return View();
        //}

        //QueryString: gÜVENLİK GEREKTİRMEYEN BİLGİLERİN URL ÜZERİNDE TAŞINMASI İÇİN KULLANILAN YAPILANMADIR. Url üzerinde taşınan veri. Normalde yazılım bu bilgiyi taşır ve işlemlerinde kullanır
        //yapılan request'in türü her ne olursa olsun QueryString değerleri taşınabilir.

        //VALİDATİON

        //Bir değerin içinde bulunduğu şartlara uygun olması durumudur. Belirlenen koşullara ve amaca uygun olup olmama durumunun kontrol edilmesidir.
        //Paralel bir şekilde client ve server tarafında uygulanmalıdır.
        public IActionResult CreateTwoProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTwoProduct(Product model)

        {
            //ModelState : MVC'de bir type'ın data annotationslarının durumunu kontrol eden ve geriye sonuç döndüren bir property

            if(!ModelState.IsValid)
            {
                //Loglama - Kullanıcı bilgilendirme
                //ViewBag.HataMesaj = ModelState.Values.FirstOrDefault(x => x.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                //    .Errors[0].ErrorMessage;
                //return null;

                //Diğer Yol -- Spanlarla property'lere Bind ettiğimiz validation mesajlarını yakalayacağız.
                //yapmam gereken gelen modelı tekrar view'e göndermek. kullanıcı yapmış old hatayı görsün
                //ModelState errors'u dolu olarak gideceğinden dolayı bu errorlardan key'leri asp-validation-for'lara karşılık gelecek keylerin mesajlarını gidecek ilgili spana yerleştirecektir.
                //Errorlardan gelen keylerle property'de asp-validation-for keylerini eşliyor bind sayesinde
                var messages = ModelState.ToList();

                return View(model);
            }
            //İşlem/Operasyon/Algoritmaya tabi tutulur.
            return View();
        }

    }




}
