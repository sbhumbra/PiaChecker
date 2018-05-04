
namespace PiaCheckerLogic
{
    public interface IParser<TResult>
    {
        TResult Parse(string content);
    }
}
