using System;
using System.Net;
using System.Threading.Tasks;

namespace PiaCheckerLogic
{
    public class PiaStatusChecker : IStatusChecker
    {
        const string PIA_URL = "http://www.privateinternetaccess.com";
        readonly IConfig _config;
        readonly IParser<Status> _parser;

        public PiaStatusChecker(IConfig config, IParser<Status> parser = null)
        {
            if (config == null)
                throw new ArgumentNullException("config");

            _config = config;
            _parser = parser ?? new PiaContentParser();
        }

        public Status Check()
        {
            try
            {
                string response = new HttpRequester(_config).Get(PIA_URL);
                return _parser.Parse(response);
            }
            catch (WebException)
            {
                return Status.Unknown;
            }
            catch (Exception ex)
            {
                HandleError(ex);
                return Status.Unknown;
            }
        }

        public async Task<Status> CheckAsync()
        {
            try
            {
                string response = await new HttpRequester(_config).GetAsync(PIA_URL);
                return _parser.Parse(response);
            }
            catch (WebException)
            {
                return Status.Unknown;
            }
            catch(Exception ex)
            {
                HandleError(ex);
                return Status.Unknown;
            }
        }

        void HandleError(Exception ex)
        {
            string type = ex.GetType().Name;
            string error = string.Format("{0} occured during a web request. {1}", type, ex.Message);
            // TODO: handle error
        }
    }
}
