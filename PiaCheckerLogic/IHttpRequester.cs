using System.Threading.Tasks;

namespace PiaCheckerLogic
{
    public interface IHttpRequester
    {
        string Get(string uri);

        Task<string> GetAsync(string uri);
    }
}
