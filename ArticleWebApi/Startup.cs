using DataTransferImplementations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ServiceImplementations;
using Microsoft.EntityFrameworkCore;

namespace ArticleWebApi {
    public class Startup {
        public Startup( IConfiguration configuration ) {
            this.Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices( IServiceCollection services ) {
            services.AddMvc( option => option.EnableEndpointRouting = false )
                .SetCompatibilityVersion( Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0 )
                .AddNewtonsoftJson( options => {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                    options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                } );
            services.AddDbContext<CustomDbContext>( opt => opt.UseSqlServer( Configuration.GetConnectionString( "CustomDbContext" ), providerOptions => providerOptions.CommandTimeout( 60 ) ) );
            services.AddScoped<ArticleRepository>();
            services.AddControllers( options => { options.RespectBrowserAcceptHeader = true; } ).AddXmlSerializerFormatters();
        }
        public void Configure( IApplicationBuilder app, IWebHostEnvironment env ) {
            if ( env.IsDevelopment() ) {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseEndpoints( endpoints => {
                endpoints.MapControllers();
            } );
        }
    }
}