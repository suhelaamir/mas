using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


namespace ProductAPI.Extensions
{
    public static class ServicesConfig
    {
        public static void AddExtensionService(this IServiceCollection services)
        {
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "V1",
                    Title = "Product API for friends",
                    Description = "A simple API that uses to some operational Business",
                   // TermsOfService = new System.Uri("...."),
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Name = "Jamal Garrage",
                        Email = "suhelaamir68@gmail.com",
                       // Url = new System.Uri("...")
                    },
                    License = new Microsoft.OpenApi.Models.OpenApiLicense
                    {
                        Name = "Use freely",
                       // Url = new System.Uri(".....")
                    }

                });
            });
        }
        public static void AddConfigureMiddleWare(this IApplicationBuilder app)
        {
            app.UseCors("CorsPolicy");
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "swagger";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "swagger api");
            });
        }
    }
}
