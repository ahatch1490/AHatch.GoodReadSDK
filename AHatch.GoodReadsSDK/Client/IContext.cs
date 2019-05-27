using System.Threading.Tasks;

namespace AHatch.GoodReadsSDK.Client
{
    public interface IContext
    {
        Task<string> GetAsync(string url);

    }
}