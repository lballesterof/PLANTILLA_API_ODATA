using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using Microsoft.OpenApi.Models;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Services;
using PLANTILLA_API_ODATA.Services.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PLANTILLA_API_ODATA
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //private static IEdmModel GetEdmModel()
        //{
        //    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
        //    //builder.EntitySet<OpeDocumentoVentum>("DocumentoVenta");
        //    builder.EntitySet<OpeTabla>("TablaBasica").EntityType.HasKey(p => p.Codigo);
        //    return builder.GetEdmModel();
        //}

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddControllers().AddOData(options =>
                options.Select().Filter().OrderBy().Expand());
            services.AddTransient<IOpeTablaServices, OpeTablaServices>();
            services.AddTransient<IOpePersonaServices, OpeProductoServices>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Services Layers Unosoft", Version = "v1" });
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PLANTILLA_API_ODATA v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
  ;
            app.UseEndpoints(endpoints =>
            {
                //endpoints.EnableDependencyInjection();
                endpoints.MapControllers();
               // endpoints.MapODataRoute("odata", "odata", GetEdmModel());
            });
        }
    }
}
