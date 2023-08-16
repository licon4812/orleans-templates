using Orleans;

namespace Templates.Orleans.Interfaces
{
    public interface IHelloWorldGrain : IGrainWithStringKey
    {
        Task<string> SayHello(string name);
    }
}