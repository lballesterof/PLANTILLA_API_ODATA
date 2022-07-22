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
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Logging;

using MediatR;

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
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using PLANTILLA_API_ODATA.Interfaces;
using PLANTILLA_API_ODATA.Repository;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace PLANTILLA_API_ODATA
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private bool CustomLifetimeValidator(DateTime? notBefore, DateTime? expires, SecurityToken tokenToValidate, TokenValidationParameters @param)
        {
            if (expires != null)
            {
                return expires > DateTime.UtcNow;
            }
            return false;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddMvc().AddJsonOptions(options =>
            //options.SerializerSettings.ReferenceLoopHandling =
            //Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DataContext")).EnableSensitiveDataLogging()
            .EnableDetailedErrors());
            services.AddControllers().AddOData(options =>
            options.Select().Filter().OrderBy().Expand().SetMaxTop(5000));
            services.AddTransient(typeof(IRepositoryAsync<>), typeof(USRepository<>));
            services.AddTransient<IOpeTablaServices, OpeTablaServices>();
            services.AddTransient<IOpePersonaServices, OpePersonaServices>();
            services.AddTransient<IOpeMesaService, OpeMesaService>();
            services.AddTransient<IOpeProductoServices, OpeProductoServices>();
            services.AddTransient<IOpePedidoService, OpePedidoService>();
            services.AddTransient<IOpeUsuarioService, OpeUsuarioService>();
            services.AddMediatR(Assembly.GetExecutingAssembly());
            Global.ConnectionStrings = Configuration.GetConnectionString("DataContext");
            Global.Secret = Configuration.GetSection("AppSettings").ToString();
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
            IdentityModelEventSource.ShowPII = true;
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
        .AddJwtBearer(x =>
        {
            x.RequireHttpsMetadata = false;
            x.SaveToken = true;
            string secret = Global.Secret;
            var securityKey = new SymmetricSecurityKey(Encoding.Default.GetBytes(secret));
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            x.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateLifetime = true,
                LifetimeValidator = CustomLifetimeValidator,
                RequireExpirationTime = true,
                IssuerSigningKey = securityKey,
                ValidateIssuerSigningKey = true,
            };
        });
        }


        public class RemoveSchemasFilter : IDocumentFilter
        {
            public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
            {

                IDictionary<string, OpenApiSchema> _remove = swaggerDoc.Components.Schemas;
                foreach (KeyValuePair<string, OpenApiSchema> _item in _remove)
                {
                    swaggerDoc.Components.Schemas.Remove(_item.Key);
                }
            }
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
            app.UseSwaggerUI(c =>


            c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebSUSPedido v1")
            
            ) ;
            ;
            IdentityModelEventSource.ShowPII = true;

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
