
using System.Configuration;
using PiaCheckerTray.Config;
using PiaCheckerLogic;

namespace PiaCheckerTray.Properties
{
   internal sealed partial class Settings : ApplicationSettingsBase, IConfig
    {
        static Settings defaultInstance = ((Settings)(Synchronized(new Settings())));
        
        public static Settings Instance
        {
            get { return defaultInstance; }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("10")]
        public int CheckPeriodSeconds
        {
            get { return ((int)(this["CheckPeriodSeconds"])); }
            set { this["CheckPeriodSeconds"] = value; }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("5")]
        public int HttpRequestTimeoutSeconds
        {
            get { return ((int)(this["HttpRequestTimeoutSeconds"])); }
            set { this["HttpRequestTimeoutSeconds"] = value; }
        }
    }
}
