namespace PiaCheckerTray.Config
{
    partial class Configuration
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.checkPeriodNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.checkPeriodLabel = new System.Windows.Forms.Label();
            this.httpTimeoutLabel = new System.Windows.Forms.Label();
            this.httpTimeoutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.checkPeriodNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.httpTimeoutNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(104, 81);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(23, 81);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // checkPeriodNumericUpDown
            // 
            this.checkPeriodNumericUpDown.Location = new System.Drawing.Point(12, 12);
            this.checkPeriodNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.checkPeriodNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.checkPeriodNumericUpDown.Name = "checkPeriodNumericUpDown";
            this.checkPeriodNumericUpDown.Size = new System.Drawing.Size(39, 20);
            this.checkPeriodNumericUpDown.TabIndex = 3;
            this.checkPeriodNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkPeriodLabel
            // 
            this.checkPeriodLabel.AutoSize = true;
            this.checkPeriodLabel.Location = new System.Drawing.Point(57, 14);
            this.checkPeriodLabel.Name = "checkPeriodLabel";
            this.checkPeriodLabel.Size = new System.Drawing.Size(85, 13);
            this.checkPeriodLabel.TabIndex = 4;
            this.checkPeriodLabel.Text = "Check Period (s)";
            // 
            // httpTimeoutLabel
            // 
            this.httpTimeoutLabel.AutoSize = true;
            this.httpTimeoutLabel.Location = new System.Drawing.Point(57, 45);
            this.httpTimeoutLabel.Name = "httpTimeoutLabel";
            this.httpTimeoutLabel.Size = new System.Drawing.Size(91, 13);
            this.httpTimeoutLabel.TabIndex = 6;
            this.httpTimeoutLabel.Text = "HTTP Timeout (s)";
            // 
            // httpTimeoutNumericUpDown
            // 
            this.httpTimeoutNumericUpDown.Location = new System.Drawing.Point(12, 43);
            this.httpTimeoutNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.httpTimeoutNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.httpTimeoutNumericUpDown.Name = "httpTimeoutNumericUpDown";
            this.httpTimeoutNumericUpDown.Size = new System.Drawing.Size(39, 20);
            this.httpTimeoutNumericUpDown.TabIndex = 5;
            this.httpTimeoutNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 116);
            this.Controls.Add(this.httpTimeoutLabel);
            this.Controls.Add(this.httpTimeoutNumericUpDown);
            this.Controls.Add(this.checkPeriodLabel);
            this.Controls.Add(this.checkPeriodNumericUpDown);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveSettings);
            this.Shown += new System.EventHandler(this.LoadSettings);
            ((System.ComponentModel.ISupportInitialize)(this.checkPeriodNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.httpTimeoutNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown checkPeriodNumericUpDown;
        private System.Windows.Forms.Label checkPeriodLabel;
        private System.Windows.Forms.Label httpTimeoutLabel;
        private System.Windows.Forms.NumericUpDown httpTimeoutNumericUpDown;
    }
}

