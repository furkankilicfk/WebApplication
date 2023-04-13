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
    {                       //Asp.Net Core uyg �z�nde console uygulamas�d�r--Asp.Net Core kendi dahilinde/f�trat�nda sunucu bar�nd�r�r.
                            //Bu sunucuyu aya�a kald�rd��� nokta bu Program.cs dosyas�d�r.
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>          //Buras� Program.cs i�inde aya�a kald�r�lacak hostun kullanaca�� konfig�rasyonlar�n nereden al�naca��n� bildirmektedir
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();           //Startup Temel Konfig�rasyon s�n�f�m�zd�r
                });
    }
}
