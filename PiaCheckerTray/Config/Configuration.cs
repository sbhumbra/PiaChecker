using PiaCheckerLogic;
using System;
using System.Windows.Forms;

namespace PiaCheckerTray.Config
{
    public partial class Configuration : Form
    {
        readonly IConfig _config;
        public Configuration(IConfig config)
        {
            _config = config;
            InitializeComponent();
        }

        private void LoadSettings(object sender, EventArgs e)
        {
            checkPeriodNumericUpDown.Value = _config.CheckPeriodSeconds;
            httpTimeoutNumericUpDown.Value = _config.HttpRequestTimeoutSeconds;
        }

        private void SaveSettings(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                _config.CheckPeriodSeconds = (int)checkPeriodNumericUpDown.Value;
                _config.HttpRequestTimeoutSeconds = (int)httpTimeoutNumericUpDown.Value;
                _config.Save();
            }
        }
    }
}