using Orleans;

namespace Orleans.Grains.Interfaces
{
    public interface IHelloWorldGrain : IGrainWithStringKey
    {
        Task<string> SayHello(string name);
    }
}