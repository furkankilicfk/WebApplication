using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.ModelMetaDataTypes
{
    public class ProductMetaData
    {
        [Required(ErrorMessage = "Lütfen Product Name'i giriniz")]
        [StringLength(100, ErrorMessage = "En fazla 100 karakter olacak şekilde giriniz")]  //Koşulları propertylere data anatotionslarla bildiriyoruz
        public string ProductName { get; set; }

       
        [EmailAddress(ErrorMessage = "Lütfen doğru bir e-posta adresi giriniz")]
        public string Email { get; set; }

        //Bu modelı hangi şartlarda sistemde kullanabileceğimizi burada belirttik
        //Validation gerektiren bütün propertyleri burada belirtiyoruz
    }
}
