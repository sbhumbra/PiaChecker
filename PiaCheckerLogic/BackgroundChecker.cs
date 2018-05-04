using System;
using System.Threading;

namespace PiaCheckerLogic
{
    public class BackgroundChecker : IBackgroundScheduler, IDisposable
    {
        readonly IStatusChecker _checker;
        readonly IStatusTarget _target;
        readonly Timer _timer;

        public BackgroundChecker(IStatusChecker checker, IStatusTarget target)
        {
            if (checker == null)
                throw new ArgumentNullException("checker");

            if (target == null)
                throw new ArgumentNullException("target");

            _checker = checker;
            _target = target;
            _timer = new Timer(OnElapsed);
        }

        public void Start(TimeSpan repeat)
        {
            _timer.Change(TimeSpan.FromMilliseconds(1), repeat);
        }

        public void End()
        {
            _timer.Change(TimeSpan.FromMilliseconds(-1), TimeSpan.Zero);
        }

        async void OnElapsed(object state)
        {
            _target.Update(Status.Checking);
            Status status = await _checker.CheckAsync();
            _target.Update(status);
        }

        public void Dispose()
        {
            _timer.Dispose();
        }
    }
}
