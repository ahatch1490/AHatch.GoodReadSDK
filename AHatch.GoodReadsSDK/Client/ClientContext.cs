using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.Extensions.Configuration;

namespace AHatch.GoodReadsSDK.Client
{
    public class ClientContext : IClientContext
    {
        private readonly IContext _context;
        private readonly IConfigurationRoot _configuration;
        public string Host { get; set; }
        public string UserId { get; set; }
        public string ApiKey { get; set; }

        public ClientContext(IContext context, IConfigurationRoot configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        
        public async Task<Response<T>> GetAsync<T>(string url)
        {
            var response = await _context.GetAsync(url);
              
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            var reader = new StringReader(response);

            var r = new Response<T> {Item = (T) serializer.Deserialize(reader)};

            return r; 
        }
    }
}