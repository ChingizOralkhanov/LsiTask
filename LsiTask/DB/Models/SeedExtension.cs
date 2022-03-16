using LsiTask.DB.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;

namespace LsiTask.DB.Models
{
    public static class SeedExtension
    {
        public static IHost Seed(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var exportRepository = scope.ServiceProvider.GetService<ExportRepository>();
                if(exportRepository == null)
                {
                    throw new Exception($"No repo is found:{nameof(exportRepository)}");
                }
                var exp1 = new Export { ID = 1, Date = DateTime.Now, Name = "Roach", Username = "Geralt", Local = "Katowice" };
                var exp2 = new Export { ID = 2, Date = DateTime.Now.AddDays(1), Name = "Visemir", Username = "Yenn", Local = "Wroclaw" };
                var exp3 = new Export { ID = 3, Date = DateTime.Now.AddDays(2), Name = "Hobbits", Username = "Isengard", Local = "Shire" };
                var exp4 = new Export { ID = 4, Date = DateTime.Now.AddDays(3), Name = "Gravy", Username = "Boromir", Local = "Lurtz" };

                exportRepository.Save(exp1);
                exportRepository.Save(exp2);
                exportRepository.Save(exp3);
                exportRepository.Save(exp4);
                    
            }
            return host;
        }
    }
}
