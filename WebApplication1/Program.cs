using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Program
    {                       //Asp.Net Core uyg özünde console uygulamasýdýr--Asp.Net Core kendi dahilinde/fýtratýnda sunucu barýndýrýr.
                            //Bu sunucuyu ayaða kaldýrdýðý nokta bu Program.cs dosyasýdýr.
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>          //Burasý Program.cs içinde ayaða kaldýrýlacak hostun kullanacaðý konfigürasyonlarýn nereden alýnacaðýný bildirmektedir
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();           //Startup Temel Konfigürasyon sýnýfýmýzdýr
                });
    }
}
