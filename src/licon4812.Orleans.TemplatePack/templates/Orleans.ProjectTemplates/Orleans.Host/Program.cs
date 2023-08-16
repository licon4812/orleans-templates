using Orleans.Providers;
using Orleans.Runtime;

namespace Orleans.Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Host.UseOrleans(siloBuilder =>
            {
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