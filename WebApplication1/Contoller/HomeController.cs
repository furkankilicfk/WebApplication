using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Contoller
{
    public class HomeController : Controller        //Bir class'ın request karşılayabilir, response döndürebilir fıtrata sahip olabilmesi için Contoller sınıfından kalıtım alması gerekiyor.
    {
        //public IActionResult Index()            //Controller sınıfları içerisinde istekleri karşılayan metotlara action metot denir.
        //{                                       //Controller sınıfları içerisinde tanımlanan tüm metotlar artık action metot olarak tanımlanacaktır.
        //                                        //Action metot: Controllera gelen isteği karşılayan ve gerekli operasyonları gerçekleştiren metotlardır.
        //    return View();                      //home/index
        //}

        //PartialViewResult'ın viewResult'tan farkı pw sayfanın sadece bir bölümü(parçası) için action döndürür, tüm sayfayı döndürmez -
        //client tabanlı Ajax isteklerinde kullanılır.
        //ViewResult, _ViewStart.cshtml dosyasını baz alır. Lakin PartialViewResult ilgili dosyayı baz almadan render edilir.
        //_ViewStart.cshtml tüm viewların başlangıç dosyasıdır. Bu dosya tüm viewler tarafından render edilmeden önce render edilir. Haliyle ViewResult bu dosyayı baz alır.

       
    
    }
}
