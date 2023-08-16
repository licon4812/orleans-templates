using Orleans;

namespace licon4812.Orleans.Templates.Grains.Interfaces
{
    public interface IHelloWorldGrain : IGrainWithStringKey
    {
        Task<string> SayHello(string name);
    }
}