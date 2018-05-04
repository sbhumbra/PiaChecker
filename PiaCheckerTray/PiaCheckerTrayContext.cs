using System;
using System.Windows.Forms;
using PiaCheckerTray.Config;
using PiaCheckerLogic;

namespace PiaCheckerTray
{
    public class PiaCheckerTrayContext : ApplicationContext
    {
        readonly IConfig _config = Properties.Settings.Instance;
        readonly NotifyIcon _notifyIcon;
        readonly Configuration _configForm;
        readonly IBackgroundScheduler _checker;

        public PiaCheckerTrayContext()
        {
            _notifyIcon = new NotifyIcon();
            _configForm = new Configuration(_config);

            MenuItem configMenuItem = new MenuItem("Configuration", new EventHandler(ShowConfig));
            MenuItem exitMenuItem = new MenuItem("Exit", new EventHandler(Exit));

            _notifyIcon.Icon = Properties.Resources.UnknownStateIcon;
            _notifyIcon.ContextMenu = new ContextMenu(new MenuItem[] { configMenuItem, exitMenuItem });
            _notifyIcon.Visible = true;

            IStatusChecker source = new PiaStatusChecker(_config);
            IStatusTarget target = new StatusNotifier(_notifyIcon);
            _checker = new BackgroundChecker(source, target);
            _checker.Start(TimeSpan.FromSeconds(_config.CheckPeriodSeconds));
        }

        void ShowConfig(object sender, EventArgs e)
        {
            if (_configForm.Visible)
                _configForm.Focus();
            else
                _configForm.ShowDialog();
        }

        void Exit(object sender, EventArgs e)
        {
            _checker.End();
            _notifyIcon.Visible = false;
            Application.Exit();
        }
    }
}
