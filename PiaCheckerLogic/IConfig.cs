
namespace PiaCheckerLogic
{
    public interface IConfig
    {
        int CheckPeriodSeconds { get; set; }
        int HttpRequestTimeoutSeconds { get; set; }

        void Save();
    }
}
