using System;
using System.Timers;
using System.Windows.Forms;
using BatteryMonitor.App.Domain;
using BatteryMonitor.App.Service;
using BatteryMonitor.Properties;

namespace BatteryMonitor
{
    public partial class FormBatteryMonitor : Form
    {
        private readonly BatteryInfoService batteryInfoService;
        private Win32_Battery batteryInfo;
        private int batteryTargetMeasure;

        public FormBatteryMonitor()
        {
            batteryInfoService = new BatteryInfoService();
            InitializeComponent();
            InitComponentsValue();
        }

        private void InitComponentsValue()
        {
            batteryInfo = batteryInfoService.Informations();
            labelBatteryName.Text = batteryInfo.Name;
            labelBatteryStatus.Text = batteryInfo.Status;
            timerCheckStatus.Interval = Settings.Default.TimeToCheck;
            batteryTargetMeasure = Settings.Default.TargetMeasure;
        }

        private void timerCheckStatus_Elapsed(object sender, ElapsedEventArgs e)
        {
            ToggleTimerCheck(false);
            InitComponentsValue();

            if (batteryInfo.EstimatedChargeRemaining > batteryTargetMeasure && batteryInfo.BatteryStatus != 1)
            {
                RestoreForm();
                NotifyToAction();
            }

            ToggleTimerCheck(true);
        }

        private void FormBatteryMonitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MinimizeForm();
        }

        private void MinimizeForm()
        {
            Hide();
            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
            notifyIcon.Visible = true;
        }

        private void RestoreForm()
        {
            Show();
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            RestoreForm();
        }

        private void ToggleTimerCheck(bool status)
        {
            timerCheckStatus.Enabled = status;
        }

        private void NotifyToAction()
        {
            var dialogResult = MessageBox.Show(
                string.Format("Atenção! A Bateria está carregada com ({0}%), retire o carregador da tomada.",
                    batteryInfo.EstimatedChargeRemaining),
                "Monitor de Bateria",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            if (dialogResult == DialogResult.OK)
                ToggleTimerCheck(true);
        }
    }
}