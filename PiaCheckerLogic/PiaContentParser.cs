
namespace PiaCheckerLogic
{
    class PiaContentParser : IParser<Status>
    {
        public Status Parse(string content)
        {
            if (content == null)
                return Status.Unknown;

            if (content.Contains("You are protected by PIA")) // TODO: more robust check
                return Status.Connected;

            return Status.NotConnected;
        }
    }
}
