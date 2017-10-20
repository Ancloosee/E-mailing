namespace Email.Forms
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.labelSendLog = new System.Windows.Forms.Label();
            this.checkBoxSendLog = new System.Windows.Forms.CheckBox();
            this.labelInterval = new System.Windows.Forms.Label();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.labelEmailLog = new System.Windows.Forms.Label();
            this.textBoxEmailLog = new System.Windows.Forms.TextBox();
            this.buttonEmailLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSendLog
            // 
            this.labelSendLog.AutoSize = true;
            this.labelSendLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSendLog.Location = new System.Drawing.Point(133, 9);
            this.labelSendLog.Name = "labelSendLog";
            this.labelSendLog.Size = new System.Drawing.Size(131, 20);
            this.labelSendLog.TabIndex = 0;
            this.labelSendLog.Text = "Отправка логов";
            // 
            // checkBoxSendLog
            // 
            this.checkBoxSendLog.AutoSize = true;
            this.checkBoxSendLog.Location = new System.Drawing.Point(15, 45);
            this.checkBoxSendLog.Name = "checkBoxSendLog";
            this.checkBoxSendLog.Size = new System.Drawing.Size(112, 17);
            this.checkBoxSendLog.TabIndex = 1;
            this.checkBoxSendLog.Text = "Отправлять логи";
            this.checkBoxSendLog.UseVisualStyleBackColor = true;
            this.checkBoxSendLog.CheckedChanged += new System.EventHandler(this.checkBoxSendLog_CheckedChanged);
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(245, 44);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(106, 13);
            this.labelInterval.TabIndex = 2;
            this.labelInterval.Text = "Интервал отправки";
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Enabled = false;
            this.numericUpDownInterval.Location = new System.Drawing.Point(357, 42);
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.ReadOnly = true;
            this.numericUpDownInterval.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownInterval.TabIndex = 3;
            this.numericUpDownInterval.ValueChanged += new System.EventHandler(this.numericUpDownInterval_ValueChanged);
            // 
            // labelEmailLog
            // 
            this.labelEmailLog.AutoSize = true;
            this.labelEmailLog.Location = new System.Drawing.Point(121, 78);
            this.labelEmailLog.Name = "labelEmailLog";
            this.labelEmailLog.Size = new System.Drawing.Size(100, 13);
            this.labelEmailLog.TabIndex = 4;
            this.labelEmailLog.Text = "Получатель Логов";
            // 
            // textBoxEmailLog
            // 
            this.textBoxEmailLog.Location = new System.Drawing.Point(73, 94);
            this.textBoxEmailLog.Name = "textBoxEmailLog";
            this.textBoxEmailLog.Size = new System.Drawing.Size(205, 20);
            this.textBoxEmailLog.TabIndex = 5;
            // 
            // buttonEmailLog
            // 
            this.buttonEmailLog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEmailLog.Location = new System.Drawing.Point(284, 94);
            this.buttonEmailLog.Name = "buttonEmailLog";
            this.buttonEmailLog.Size = new System.Drawing.Size(68, 20);
            this.buttonEmailLog.TabIndex = 6;
            this.buttonEmailLog.Text = "Принять";
            this.buttonEmailLog.UseVisualStyleBackColor = true;
            this.buttonEmailLog.Click += new System.EventHandler(this.buttonEmailLog_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 147);
            this.Controls.Add(this.buttonEmailLog);
            this.Controls.Add(this.textBoxEmailLog);
            this.Controls.Add(this.labelEmailLog);
            this.Controls.Add(this.numericUpDownInterval);
            this.Controls.Add(this.labelInterval);
            this.Controls.Add(this.checkBoxSendLog);
            this.Controls.Add(this.labelSendLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setting";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSendLog;
        private System.Windows.Forms.CheckBox checkBoxSendLog;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
        private System.Windows.Forms.Label labelEmailLog;
        private System.Windows.Forms.TextBox textBoxEmailLog;
        private System.Windows.Forms.Button buttonEmailLog;
    }
}