namespace BatteryMonitor
{
    partial class FormBatteryMonitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBatteryMonitor));
            this.timerCheckStatus = new System.Timers.Timer();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelBatteryNameTitle = new System.Windows.Forms.Label();
            this.labelBatteryName = new System.Windows.Forms.Label();
            this.labelBatteryStatus = new System.Windows.Forms.Label();
            this.labelBatteryStatusTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.timerCheckStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // timerCheckStatus
            // 
            this.timerCheckStatus.Enabled = true;
            this.timerCheckStatus.Interval = 30000D;
            this.timerCheckStatus.SynchronizingObject = this;
            this.timerCheckStatus.Elapsed += new System.Timers.ElapsedEventHandler(this.timerCheckStatus_Elapsed);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Monitorando o carregamento da Bateria";
            this.notifyIcon.BalloonTipTitle = "Monitor de Bateria";
            this.notifyIcon.Icon = ((System.Drawing.Icon) (resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // labelBatteryNameTitle
            // 
            this.labelBatteryNameTitle.Location = new System.Drawing.Point(23, 19);
            this.labelBatteryNameTitle.Name = "labelBatteryNameTitle";
            this.labelBatteryNameTitle.Size = new System.Drawing.Size(100, 23);
            this.labelBatteryNameTitle.TabIndex = 0;
            this.labelBatteryNameTitle.Text = "Nome da Bateria";
            this.labelBatteryNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBatteryName
            // 
            this.labelBatteryName.Location = new System.Drawing.Point(143, 19);
            this.labelBatteryName.Name = "labelBatteryName";
            this.labelBatteryName.Size = new System.Drawing.Size(237, 23);
            this.labelBatteryName.TabIndex = 0;
            this.labelBatteryName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBatteryStatus
            // 
            this.labelBatteryStatus.Location = new System.Drawing.Point(143, 54);
            this.labelBatteryStatus.Name = "labelBatteryStatus";
            this.labelBatteryStatus.Size = new System.Drawing.Size(237, 23);
            this.labelBatteryStatus.TabIndex = 2;
            this.labelBatteryStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBatteryStatusTitle
            // 
            this.labelBatteryStatusTitle.Location = new System.Drawing.Point(23, 54);
            this.labelBatteryStatusTitle.Name = "labelBatteryStatusTitle";
            this.labelBatteryStatusTitle.Size = new System.Drawing.Size(100, 23);
            this.labelBatteryStatusTitle.TabIndex = 1;
            this.labelBatteryStatusTitle.Text = "Status";
            this.labelBatteryStatusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormBatteryMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 211);
            this.Controls.Add(this.labelBatteryStatus);
            this.Controls.Add(this.labelBatteryStatusTitle);
            this.Controls.Add(this.labelBatteryName);
            this.Controls.Add(this.labelBatteryNameTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormBatteryMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor de Nateria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBatteryMonitor_FormClosing);
            ((System.ComponentModel.ISupportInitialize) (this.timerCheckStatus)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelBatteryStatus;
        private System.Windows.Forms.Label labelBatteryStatusTitle;

        private System.Windows.Forms.Label labelBatteryNameTitle;
        private System.Windows.Forms.Label labelBatteryName;

        private System.Windows.Forms.NotifyIcon notifyIcon;

        private System.Timers.Timer timerCheckStatus;

        #endregion
    }
}