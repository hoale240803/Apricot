using Apricot.API.Extensions;

namespace Apricot.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.Configure<JwtBearerTokenSettings>(Configuration.GetSection("JwtBearerTokenSettings"));



            // add cors

            services.AddCors();

            services.AddControllers();

            // adđ databases
            services.AddDatabases(Configuration);

            // add repositories
            services.AddRepositories();

            // add services
            services.AddServices();

            //add authentication
            //services.AddAuthen(Configuration);
            // add controlers

            // add config swagger
            services.AddSwagger();

            // auto mapper
            //services.AddAutoMapper(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
            }

            // cors
            app.UseCors(x => x
            .AllowAnyMethod()
            .AllowAnyHeader()
            .SetIsOriginAllowed(origin => true) // allow any origin
            .AllowCredentials()); // allow credentials

            // use static files
            app.UseStaticFiles();

            app.UseHttpsRedirection();

            app.UseRouting();
            // authentication
            app.UseAuthentication();

            // authorization
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}