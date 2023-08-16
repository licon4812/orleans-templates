using Orleans.Configuration;
using Orleans.Providers;
using Orleans.Runtime;

namespace Templates.Orleans.Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Host.UseOrleans(siloBuilder =>
            {
                // Configure your cluster and service information
                siloBuilder.Configure<ClusterOptions>(options =>
                {
                    options.ClusterId = "dev"; // Set your ClusterId
                    options.ServiceId = "orleans"; // Set your ServiceId
                });
                // Use localhost clustering by default
                siloBuilder.UseLocalhostClustering();
                // Setup memory as the grain storage - Add your own providers as required
                siloBuilder.AddMemoryGrainStorageAsDefault();
                // Setup memory streams - Add your own providers as required
                siloBuilder.AddMemoryStreams<DefaultMemoryMessageBodySerializer>("MemoryStreamProvider");
                // Enable streaming
                siloBuilder.AddStreaming();
            });

            var app = builder.Build();
            app.Run();
        }
    }
}