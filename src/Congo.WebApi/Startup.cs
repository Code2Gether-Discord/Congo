using Congo.WebApi.Extensions;
using Congo.WebApi.Validators;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.OpenApi.Models;

namespace Congo.WebApi;

public class Startup
{
    readonly string _CORS_DEV = "cors_dev";
    readonly string _CORS_PROD = "cors_prod";

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddAppServices(Configuration);
        services.AddControllers();

        services.AddCors(options =>
        {
            options.AddPolicy(_CORS_DEV, policy =>
                policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            options.AddPolicy(_CORS_PROD, policy =>
            {
                // TODO: Multiple Origins from env vars
                string ALLOWED_ORIGIN = Environment.GetEnvironmentVariable("ALLOWED_ORIGIN");

                if (!string.IsNullOrWhiteSpace(ALLOWED_ORIGIN))
                {
                    //Debug.WriteLine("ALLOWED_ORIGIN = " + ALLOWED_ORIGIN);
                    policy.WithOrigins(ALLOWED_ORIGIN).AllowAnyMethod().AllowAnyHeader();
                }
                else if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") != "Development")
                {
                    // Don't throw any exceptions in development, as this policy should only be used in production
                    throw new Exception("No value set for mandatory environment variable ALLOWED_ORIGIN.");
                }
            });
        });
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Congo.WebApi", Version = "v1" });
        });
        services.AddMediatR(typeof(Startup).Assembly);
        services.AddFluentValidation(fv =>
            fv.RegisterValidatorsFromAssemblyContaining<InsertProductRequestValidator>());
        MapperExtensions.AddPriceMappingConfig();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-5.0#middleware-order-1

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Congo.WebApi v1"));
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseCors(env.IsDevelopment() ? _CORS_DEV : _CORS_PROD);

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}