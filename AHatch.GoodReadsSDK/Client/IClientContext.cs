using System.Threading.Tasks;

namespace AHatch.GoodReadsSDK.Client
{
    public interface IClientContext
    {
        string Host { get; set; }
        string UserId { get; set; }
        string ApiKey { get; set; }
        Task<Response<T>> GetAsync<T>(string Url);
    }
}