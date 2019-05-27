using System;
using System.Linq.Expressions;
using System.Net.Http;
using System.Threading.Tasks;

namespace AHatch.GoodReadsSDK.Client
{
    public class Context: IContext
    {
        public static HttpClient _HttpClient = new HttpClient();


        public async Task<string> GetAsync(string url)
        {
            var response = await _HttpClient.GetAsync(url);
            if (response.IsSuccessStatusCode) return await response.Content.ReadAsStringAsync() ;
            var message =
                $"UnsuccessfulStatusCode Returned From server {await response.Content.ReadAsStringAsync()}";
            throw new GoodReadsServerException(message,response.StatusCode.ToString());

        }
    }

    public class GoodReadsServerException : Exception
    {
        public string ServerStatusCode { get; set; }

        public GoodReadsServerException(string message = null, string statusCode = null,
            Exception innerException = null) : base(message, innerException)
        {
            ServerStatusCode = statusCode;
        }

    }
}