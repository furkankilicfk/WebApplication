using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Contoller
{
    public class HomeController : Controller        //Bir class'ın request karşılayabilir, response döndürebilir fıtrata sahip olabilmesi için Contoller sınıfından kalıtım alması gerekiyor.
    {
        public IActionResult Index()            //Controller sınıfları içerisinde istekleri karşılayan metotlara action metot denir.
        {                                       //Controller sınıfları içerisinde tanımlanan tüm metotlar artık action metot olarak tanımlanacaktır.
                                                //Action metot: Controllera gelen isteği karşılayan ve gerekli operasyonları gerçekleştiren metotlardır.
            return View();                      //home/index
        }
    }
}
