using Orleans;

namespace IGrain
{
    public interface IGrain : IGrainWithStringKey
    {
        Task<string> SayHello(string name);
    }
}