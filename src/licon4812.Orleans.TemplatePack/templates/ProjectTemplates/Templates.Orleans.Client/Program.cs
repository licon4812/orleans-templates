using Orleans.Configuration;
using Orleans.Runtime;

namespace licon4812.Orleans.Templates.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();

            builder.Host.UseOrleansClient((context, client) => {
                client.UseLocalhostClustering();
                client.Configure<ClusterOptions>(options =>
                {
                    options.ClusterId = "dev";
                    options.ServiceId = "orleans";
                });
            });

            var app = builder.Build();
            app.MapControllers();            
            app.Run();
        }
    }
}