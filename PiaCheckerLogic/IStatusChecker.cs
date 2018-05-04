
using System.Threading.Tasks;

namespace PiaCheckerLogic
{
    public interface IStatusChecker
    {
        Status Check();

        Task<Status> CheckAsync();
    }
}
