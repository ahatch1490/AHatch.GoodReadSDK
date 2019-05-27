using System.Threading.Tasks;
using AHatch.GoodReadsSDK.Client;

namespace AHatch.GoodReadsSDK.Test
{
    public class StubClient: IContext
    {
        private readonly string _data; 
        public StubClient(string data)
        {
            _data = data;
        }

        public async Task<string> GetAsync(string url)
        {
            return  _data;
        }
    }

}