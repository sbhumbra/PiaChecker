using PiaCheckerLogic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PiaCheckerTray
{
    class StatusNotifier : IStatusTarget
    {
        readonly NotifyIcon _icon;
        Status _lastKnownState;

        public StatusNotifier(NotifyIcon icon)
        {
            if (icon == null)
                throw new ArgumentNullException("icon");
            
            _icon = icon;
        }

        public void Update(Status status)
        {
            Icon icon = GetIcon(status);

            bool lostConnection = IsConnectionLost(status, icon);

            _icon.Icon = icon;
            _icon.Text = BuildNotificationText(status);

            if (lostConnection)
                MessageBox.Show(string.Format("VPN dropped at {0}", DateTime.Now.ToLongTimeString()));
        }

        bool IsConnectionLost(Status status, Icon icon)
        {
            bool wasConnected = _lastKnownState == Status.Connected;
            bool isDisconnected = status == Status.NotConnected;
            bool lostConnection = wasConnected && isDisconnected;

            _lastKnownState = status == Status.Connected || status == Status.NotConnected ? status : _lastKnownState;
            return lostConnection;
        }

        string BuildNotificationText(Status status)
        {
            if(status == Status.Checking)
                return string.Format("{0} {1}...", DateTime.Now.ToLongTimeString(), status);

            return string.Format("{0}. Last checked {1}", status, DateTime.Now.ToLongTimeString());
        }

        Icon GetIcon(Status status)
        {
            switch (status)
            {
                case Status.Unknown:
                    return Properties.Resources.UnknownStateIcon;
                case Status.NotConnected:
                    return Properties.Resources.NotConnectedIcon;
                case Status.Checking:
                    if(_lastKnownState == Status.Connected)
                        return Properties.Resources.ConnectedIcon;

                    return Properties.Resources.ConnectingIcon;
                case Status.Connected:
                    return Properties.Resources.ConnectedIcon;
                default:
                    return Properties.Resources.UnknownStateIcon;
            }
        }
    }
}
