namespace Email.Forms
{
    partial class AboutProgramForm
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
            this.labelAttention = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelGmail = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelAttention
            // 
            this.labelAttention.AutoSize = true;
            this.labelAttention.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAttention.Location = new System.Drawing.Point(110, 18);
            this.labelAttention.Name = "labelAttention";
            this.labelAttention.Size = new System.Drawing.Size(85, 20);
            this.labelAttention.TabIndex = 0;
            this.labelAttention.Text = "Внимание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Для воизбежания бана ваших профилей\r\nВам нужно включить доступ нежелательным прил" +
    "ожениям\r\nКак это сделать:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelGmail
            // 
            this.linkLabelGmail.AutoSize = true;
            this.linkLabelGmail.Location = new System.Drawing.Point(139, 104);
            this.linkLabelGmail.Name = "linkLabelGmail";
            this.linkLabelGmail.Size = new System.Drawing.Size(33, 13);
            this.linkLabelGmail.TabIndex = 2;
            this.linkLabelGmail.TabStop = true;
            this.linkLabelGmail.Text = "Gmail";
            this.linkLabelGmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGmail_LinkClicked);
            // 
            // AboutProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 164);
            this.Controls.Add(this.linkLabelGmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAttention);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutProgramForm";
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAttention;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelGmail;
    }
}