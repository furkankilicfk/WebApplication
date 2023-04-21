using FluentValidation;

namespace WebApplication1.Models.Validators
{
    public class ProductValidator : AbstractValidator<Product>  //Sistemdeki kullanılan sınıflardan hangisinin validator sınıfı old ayırt edebilmek için türemesi gerektiği sınıfı verdik.
                                                                //Hangi modelı validate edeceğimizi de generic olarak vermeliyiz.
    {
        public ProductValidator() 
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email boş olamaz"); //Tümmmm data anatotionslar burada çıkıyor. Kısıtlamaları hep burada yapıyoruz.
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen doğru bir email giriniz");

            RuleFor(x => x.ProductName).NotNull().WithMessage("Lütfen product name'i boş geçmeyiniz");
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage("Lütfen 100 karakterden fazla girmeyiniz");
        }
        //Backendde oluşturmuş olduğumuz validation kodlarını belli kütüphanelerle hiç ekstra koda gerek kalmadan clienta taşıyabiliriz.
        //Bu yolla her iki tarafta ayrı ayrı çalışmayacağımız için tutarlı ve esnek bir yapı kurmuş olacağız
    }
}
