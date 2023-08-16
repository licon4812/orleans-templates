using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Runtime;
using System.Threading.Tasks;

namespace licon4812.Orleans.Templates.Grain
{
    public class HelloWorldGrain : Grain, IHelloWorldGrain
    {
        private readonly ILogger<HelloWorldGrain> _logger;
        public IGrainContext GrainContext { get; }

        public HelloWorldGrain(IGrainContext grainContext, ILogger<HelloWorldGrain> logger)
        {
            _logger = logger;
            GrainContext = grainContext;
        }

        public Task<string> SayHello(string name)
        {
            _logger.LogInformation("Received {Name}", name);

            return Task.FromResult($"Hello {name}");
        }
    }
}