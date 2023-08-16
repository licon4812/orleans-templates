using Orleans;

namespace Orleans.Interfaces
{
    public interface IHelloWorldGrain : IGrainWithStringKey
    {
        Task<string> SayHello(string name);
    }
}