using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace PiaCheckerLogic
{
    class HttpRequester : IHttpRequester
    {
        readonly IConfig _config;

        public HttpRequester(IConfig config)
        {
            if (config == null)
                throw new ArgumentNullException("config");

            _config = config;
        }

        public string Get(string uri)
        {
            HttpWebRequest request = BuildRequest(uri);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (StreamReader reader = GetStream(response))
            {
                return reader.ReadToEnd();
            }
        }

        public async Task<string> GetAsync(string uri)
        {
            HttpWebRequest request = BuildRequest(uri);

            HttpWebResponse response = (HttpWebResponse)(await request.GetResponseAsync());

            using (StreamReader reader = GetStream(response))
            {
                return await reader.ReadToEndAsync();
            }
        }

        HttpWebRequest BuildRequest(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Timeout = _config.HttpRequestTimeoutSeconds * 1000;
            return request;
        }

        StreamReader GetStream(HttpWebResponse response)
        {
            Stream stream = response.GetResponseStream();
            return new StreamReader(stream);
        }
    }
}
