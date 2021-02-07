using AutoMapper;
using BusinessService.Implementation;
using BusinessService.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductAPI.Extensions;
using Repositories.dbContext;
using Repositories.Implementation;
using Repositories.Interface;

namespace ProductAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddCors(options => {
                options.AddPolicy(
                    "CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
                    );
            });
            //get connection string
            var connection = Configuration.GetConnectionString("SqlConnectionString");
            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(connection));

            //Add service extnsion
            ServicesConfig.AddExtensionService(services);
            services.AddAutoMapper();


            //services.AddAutoMapper();

            //Repository registration
            services.AddScoped(typeof(ICustomersRepository), typeof(CustomersRepository));
            services.AddScoped(typeof(IProvideServiceRepository), typeof(ProvideServiceRepository));

            //Service registration
            services.AddScoped(typeof(ICustomersService), typeof(CustomersService));
            services.AddScoped(typeof(IProvideServiceService), typeof(ProvideServiceService));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            ServicesConfig.AddConfigureMiddleWare(app);
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseHsts();
            //}
            
            //app.UseHttpsRedirection();
            app.UseMvc();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
                routes.MapRoute(
                  name: "default",
                  template: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
