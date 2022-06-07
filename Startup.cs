using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using Microsoft.OpenApi.Models;
using PLANTILLA_API_ODATA.DbContexts;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Services;
using PLANTILLA_API_ODATA.Services.AutoMapper;
using PLANTILLA_API_ODATA.Services.Helpers.Common;
using PLANTILLA_API_ODATA.Services.Mesas;
using PLANTILLA_API_ODATA.Services.Pedido;
using PLANTILLA_API_ODATA.Services.Persona;
using PLANTILLA_API_ODATA.Services.Productos;
using PLANTILLA_API_ODATA.Services.Usuario;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using IOpeMesaService = PLANTILLA_API_ODATA.Services.Mesas.IOpeMesaService;

namespace PLANTILLA_API_ODATA
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

       
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddMvc().AddJsonOptions(options =>
            //options.SerializerSettings.ReferenceLoopHandling =
            //Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DataContext")).EnableSensitiveDataLogging()
            .EnableDetailedErrors());
            services.AddControllers().AddOData(options =>
            options.Select().Filter().OrderBy().Expand());
            services.AddTransient<IOpeTablaServices, OpeTablaServices>();
            services.AddTransient<IOpePersonaServices, OpePersonaServices>();
            services.AddTransient<IOpeMesaService, OpeMesaService>();
            services.AddTransient<IOpeProductoServices, OpeProductoServices>();
            services.AddTransient<IOpePedidoService, OpePedidoService>();
            services.AddTransient<IOpeUsuarioService, OpeUsuarioService>();
            Global.ConnectionStrings = Configuration.GetConnectionString("DataContext");
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Services Layers Unosoft", Version = "v1" });
            });


            var mapperConfig = new MapperConfiguration(m =>
            {

                m.AddProfile(new AutoMapperProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // add hardcoded test user to db on startup,  
            // plain text password is used for simplicity, hashed passwords should be used in production applications
            //context.Users.Add(new User { FirstName = "Test", LastName = "User", Username = "test", Password = "test" });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebSUSPedido v1"));
            }
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebSUSPedido v1"));


            app.UseRouting();

            // global cors policy
            app.UseCors(x => x
                .SetIsOriginAllowed(origin => true)
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(x => x.MapControllers());
        }
    }
}
