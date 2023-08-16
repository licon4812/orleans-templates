using Orleans;

namespace licon4812.Orleans.Templates.Grain
{
    public interface IGrain : IGrainWithStringKey
    {
        Task<string> SayHello(string name);
    }
}