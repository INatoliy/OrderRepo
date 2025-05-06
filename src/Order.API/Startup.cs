using Microsoft.OpenApi.Models;

namespace Order.API;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; set; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddSwaggerGen(service =>
            service.SwaggerDoc("V1", new OpenApiInfo
            {
                Version = "v1",
                Title = "Order API",
                Description = "API для управления заказами",
            }));
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
            app.UseDeveloperExceptionPage();
        else
            app.UseExceptionHandler("/error");
        
        app.UseStatusCodePages();
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "My VarketplaceAPI V1");
            options.RoutePrefix = string.Empty;
        });
        app.UseRouting();
        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}