using System;

namespace PiaCheckerLogic
{
    public interface IBackgroundScheduler
    {
        void Start(TimeSpan repeat);

        void End();
    }
}
