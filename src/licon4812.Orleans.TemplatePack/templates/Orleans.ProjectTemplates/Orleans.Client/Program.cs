using Orleans.Configuration;
using Orleans.Runtime;

namespace Orleans.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Host.UseOrleansClient((context, client) => {
                client.UseLocalhostClustering();
                client.Configure<ClusterOptions>(options =>
                {
                    options.ClusterId = "dev";
                    options.ServiceId = "orleans";
                });
            });

            var app = builder.Build();
            app.Run();
        }
    }
}