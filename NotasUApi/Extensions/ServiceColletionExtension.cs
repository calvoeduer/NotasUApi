using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotasUApi.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "NotasU API",
                    Description = "NotaU API - ASP.NET Core Web",
                    TermsOfService = new Uri("https://cla.dotnetfoundation.org/"),
                    Contact = new OpenApiContact
                    {
                        Name = "Eduer José Calvo Acuña",
                        Email = "ejcalvo@unicesar.edu.co",
                        Url = new Uri("https://github.com/calvoeduer/")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Dotnet foundation license",
                        Url = new Uri("https://www.byasystems.co/license")
                    }
                });
            });

            return services;
        }

    }
}
