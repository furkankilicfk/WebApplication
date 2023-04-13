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
        public void ConfigureServices(IServiceCollection services)          //Bu uygulamada kullan�lacak servislerin eklendi�i/konfig�re edildi metottur.
                                                                            //Servisler: belirli i�lere odaklanm�� ve o i�in sorumlulu�unu �stlenmi� k�t�phaneler/s�n�flar vs.
        {
            services.AddMvc();          //Asp.Net Core uygulamas�nda MVC mimarisini kullanabilmek i�in uygulamada Controller ve View yap�lanmalar�n�n eklenmesi gerekmektedir.
                                        //Bunun i�in �ncelikle bu servis uygulamaya ekleniyor. B�ylece uygulama MVC davran��� sergileyebilecektir.
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)          //Bu metotta da uygulamada kullan�lacak middleware/ara katmanlar/ara yaz�l�mlar� �a��rmaktay�z
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

            app.UseRouting();           //Gelen iste�in hangi Controllerlara ayr�laca��, hangi rotaya evrilece�i bu middleware sayesinde belirleniyor.

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>       //endpoind kavram�, istek yaparken yapm�� oldu�umuz adresin ta kendisi. Yap�lan iste�in var�� noktas�(url). �stek adresi.
                                                //Bu uygulamaya gelen isteklerin hangi rotalar/�ablonlar e�li�inde gelebilece�ini buradan belirtece�iz
            {
                endpoints.MapRazorPages();

                endpoints.MapDefaultControllerRoute();      //Default olan endpoint �emas�. Bu uygulamaya yap�lacak olan istekler bu �emaya uygun bir �ekilde yap�lacakt�r.
                                                            //Uygulaman�n istek format�n� belirlemi� oluyoruz.  {controller=Home}/{action=Index}/{id?} Bo� geliyorsa bunlar� tetikle. 
                                                            //Endpoint tan�mlamas�nda s�sl� parantez i�erisinde parametre tan�mlanabilmektedir. Bunlar herhangi bir isimde olabilir.
                                                            //contoller ve action �n tan�ml� olan parametrelerdir
            });
        }
    }
}
