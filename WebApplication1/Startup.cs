using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)            
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)          //Bu uygulamada kullanýlacak servislerin eklendiði/konfigüre edildi metottur.
                                                                            //Servisler: belirli iþlere odaklanmýþ ve o iþin sorumluluðunu üstlenmiþ kütüphaneler/sýnýflar vs.
        {
            services.AddMvc();          //Asp.Net Core uygulamasýnda MVC mimarisini kullanabilmek için uygulamada Controller ve View yapýlanmalarýnýn eklenmesi gerekmektedir.
                                        //Bunun için öncelikle bu servis uygulamaya ekleniyor. Böylece uygulama MVC davranýþý sergileyebilecektir.
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)          //Bu metotta da uygulamada kullanýlacak middleware/ara katmanlar/ara yazýlýmlarý çaðýrmaktayýz
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();           //Gelen isteðin hangi Controllerlara ayrýlacaðý, hangi rotaya evrileceði bu middleware sayesinde belirleniyor.

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>       //endpoind kavramý, istek yaparken yapmýþ olduðumuz adresin ta kendisi. Yapýlan isteðin varýþ noktasý(url). Ýstek adresi.
                                                //Bu uygulamaya gelen isteklerin hangi rotalar/þablonlar eþliðinde gelebileceðini buradan belirteceðiz
            {
                endpoints.MapRazorPages();

                endpoints.MapDefaultControllerRoute();      //Default olan endpoint þemasý. Bu uygulamaya yapýlacak olan istekler bu þemaya uygun bir þekilde yapýlacaktýr.
                                                            //Uygulamanýn istek formatýný belirlemiþ oluyoruz.  {controller=Home}/{action=Index}/{id?} Boþ geliyorsa bunlarý tetikle. 
                                                            //Endpoint tanýmlamasýnda süslü parantez içerisinde parametre tanýmlanabilmektedir. Bunlar herhangi bir isimde olabilir.
                                                            //contoller ve action ön tanýmlý olan parametrelerdir
            });
        }
    }
}
