using Serilog;

namespace Order.API
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static IHost CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .UseSerilog((context, services, config) =>
                {
                    config
                        .ReadFrom.Configuration(context.Configuration)
                        .ReadFrom.Services(services);
                })
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); })
                .Build();
        }
    }
}