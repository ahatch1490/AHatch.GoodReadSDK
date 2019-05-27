using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AHatch.GoodReadsSDK.Client
{
    public class GoodreadsContext : IContext
    {
        public static HttpClient Client = new HttpClient(); 
        public async Task<string> GetAsync(string url)
        {
           var result = await GoodreadsContext.Client.GetAsync(new Uri(url));
           return await result.Content.ReadAsStringAsync();
        }
    }
}