namespace Email
{
    partial class AddTaskForm
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
            this.labelTaskName = new System.Windows.Forms.Label();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.labelSenderMail = new System.Windows.Forms.Label();
            this.textBoxSenderMail = new System.Windows.Forms.TextBox();
            this.labelAdresseeMail = new System.Windows.Forms.Label();
            this.textBoxAdresseeMail = new System.Windows.Forms.TextBox();
            this.buttonAddNewEmail = new System.Windows.Forms.Button();
            this.buttonReadEmailFromFile = new System.Windows.Forms.Button();
            this.toolTipAddNewEmail = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipReadEmailFromFile = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxShowAllAdresseeMails = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.labelSubject = new System.Windows.Forms.Label();
            this.textBoxSubkect = new System.Windows.Forms.TextBox();
            this.labelBody = new System.Windows.Forms.Label();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.labelMailPassword = new System.Windows.Forms.Label();
            this.textBoxMailPassword = new System.Windows.Forms.TextBox();
            this.buttonAttachment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTaskName
            // 
            this.labelTaskName.AutoSize = true;
            this.labelTaskName.Location = new System.Drawing.Point(2, 45);
            this.labelTaskName.Name = "labelTaskName";
            this.labelTaskName.Size = new System.Drawing.Size(108, 13);
            this.labelTaskName.TabIndex = 0;
            this.labelTaskName.Text = "Название задания: ";
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Location = new System.Drawing.Point(143, 42);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(303, 20);
            this.textBoxTaskName.TabIndex = 1;
            // 
            // labelSenderMail
            // 
            this.labelSenderMail.AutoSize = true;
            this.labelSenderMail.Location = new System.Drawing.Point(2, 72);
            this.labelSenderMail.Name = "labelSenderMail";
            this.labelSenderMail.Size = new System.Drawing.Size(108, 13);
            this.labelSenderMail.TabIndex = 0;
            this.labelSenderMail.Text = "Email отправителя:  ";
            // 
            // textBoxSenderMail
            // 
            this.textBoxSenderMail.Location = new System.Drawing.Point(143, 69);
            this.textBoxSenderMail.Name = "textBoxSenderMail";
            this.textBoxSenderMail.Size = new System.Drawing.Size(303, 20);
            this.textBoxSenderMail.TabIndex = 1;
            // 
            // labelAdresseeMail
            // 
            this.labelAdresseeMail.AutoSize = true;
            this.labelAdresseeMail.Location = new System.Drawing.Point(12, 139);
            this.labelAdresseeMail.Name = "labelAdresseeMail";
            this.labelAdresseeMail.Size = new System.Drawing.Size(107, 13);
            this.labelAdresseeMail.TabIndex = 0;
            this.labelAdresseeMail.Text = "Email получателей:  ";
            // 
            // textBoxAdresseeMail
            // 
            this.textBoxAdresseeMail.Location = new System.Drawing.Point(147, 136);
            this.textBoxAdresseeMail.Name = "textBoxAdresseeMail";
            this.textBoxAdresseeMail.Size = new System.Drawing.Size(208, 20);
            this.textBoxAdresseeMail.TabIndex = 1;
            // 
            // buttonAddNewEmail
            // 
            this.buttonAddNewEmail.Location = new System.Drawing.Point(371, 136);
            this.buttonAddNewEmail.Name = "buttonAddNewEmail";
            this.buttonAddNewEmail.Size = new System.Drawing.Size(28, 23);
            this.buttonAddNewEmail.TabIndex = 2;
            this.buttonAddNewEmail.Text = "+";
            this.buttonAddNewEmail.UseVisualStyleBackColor = true;
            this.buttonAddNewEmail.Click += new System.EventHandler(this.buttonAddNewEmail_Click);
            // 
            // buttonReadEmailFromFile
            // 
            this.buttonReadEmailFromFile.Location = new System.Drawing.Point(405, 136);
            this.buttonReadEmailFromFile.Name = "buttonReadEmailFromFile";
            this.buttonReadEmailFromFile.Size = new System.Drawing.Size(28, 23);
            this.buttonReadEmailFromFile.TabIndex = 2;
            this.buttonReadEmailFromFile.Text = "...";
            this.buttonReadEmailFromFile.UseVisualStyleBackColor = true;
            this.buttonReadEmailFromFile.Click += new System.EventHandler(this.buttonReadEmailFromFile_Click);
            // 
            // toolTipAddNewEmail
            // 
            this.toolTipAddNewEmail.ToolTipTitle = "Добавить новый email";
            // 
            // toolTipReadEmailFromFile
            // 
            this.toolTipReadEmailFromFile.ToolTipTitle = "Считай emails с файла";
            // 
            // textBoxShowAllAdresseeMails
            // 
            this.textBoxShowAllAdresseeMails.Location = new System.Drawing.Point(15, 181);
            this.textBoxShowAllAdresseeMails.Multiline = true;
            this.textBoxShowAllAdresseeMails.Name = "textBoxShowAllAdresseeMails";
            this.textBoxShowAllAdresseeMails.ReadOnly = true;
            this.textBoxShowAllAdresseeMails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxShowAllAdresseeMails.Size = new System.Drawing.Size(418, 152);
            this.textBoxShowAllAdresseeMails.TabIndex = 3;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(336, 339);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(226, 339);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 5;
            this.buttonPrevious.Text = "Назад";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(2, 21);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(81, 13);
            this.labelSubject.TabIndex = 6;
            this.labelSubject.Text = "Тема письма: ";
            this.labelSubject.Visible = false;
            // 
            // textBoxSubkect
            // 
            this.textBoxSubkect.Location = new System.Drawing.Point(99, 18);
            this.textBoxSubkect.Name = "textBoxSubkect";
            this.textBoxSubkect.Size = new System.Drawing.Size(357, 20);
            this.textBoxSubkect.TabIndex = 7;
            this.textBoxSubkect.Visible = false;
            // 
            // labelBody
            // 
            this.labelBody.AutoSize = true;
            this.labelBody.Location = new System.Drawing.Point(12, 49);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(40, 13);
            this.labelBody.TabIndex = 8;
            this.labelBody.Text = "Текст:";
            this.labelBody.Visible = false;
            this.labelBody.Click += new System.EventHandler(this.labelBody_Click);
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(5, 68);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(451, 265);
            this.textBoxBody.TabIndex = 9;
            this.textBoxBody.Visible = false;
            this.textBoxBody.TextChanged += new System.EventHandler(this.textBoxBody_TextChanged);
            // 
            // labelMailPassword
            // 
            this.labelMailPassword.AutoSize = true;
            this.labelMailPassword.Location = new System.Drawing.Point(2, 98);
            this.labelMailPassword.Name = "labelMailPassword";
            this.labelMailPassword.Size = new System.Drawing.Size(92, 13);
            this.labelMailPassword.TabIndex = 0;
            this.labelMailPassword.Text = "Пароль от почты";
            // 
            // textBoxMailPassword
            // 
            this.textBoxMailPassword.Location = new System.Drawing.Point(143, 95);
            this.textBoxMailPassword.Name = "textBoxMailPassword";
            this.textBoxMailPassword.PasswordChar = '*';
            this.textBoxMailPassword.Size = new System.Drawing.Size(303, 20);
            this.textBoxMailPassword.TabIndex = 1;
            // 
            // buttonAttachment
            // 
            this.buttonAttachment.Location = new System.Drawing.Point(15, 339);
            this.buttonAttachment.Name = "buttonAttachment";
            this.buttonAttachment.Size = new System.Drawing.Size(75, 23);
            this.buttonAttachment.TabIndex = 10;
            this.buttonAttachment.Text = "Вложения:";
            this.buttonAttachment.UseVisualStyleBackColor = true;
            this.buttonAttachment.Visible = false;
            this.buttonAttachment.Click += new System.EventHandler(this.buttonAttachment_Click);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 374);
            this.Controls.Add(this.buttonAttachment);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.labelBody);
            this.Controls.Add(this.textBoxSubkect);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textBoxShowAllAdresseeMails);
            this.Controls.Add(this.buttonReadEmailFromFile);
            this.Controls.Add(this.buttonAddNewEmail);
            this.Controls.Add(this.textBoxAdresseeMail);
            this.Controls.Add(this.textBoxMailPassword);
            this.Controls.Add(this.textBoxSenderMail);
            this.Controls.Add(this.labelMailPassword);
            this.Controls.Add(this.labelAdresseeMail);
            this.Controls.Add(this.labelSenderMail);
            this.Controls.Add(this.textBoxTaskName);
            this.Controls.Add(this.labelTaskName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTaskForm";
            this.Text = "Добавление задания";
            this.Load += new System.EventHandler(this.AddTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTaskName;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.Label labelSenderMail;
        private System.Windows.Forms.TextBox textBoxSenderMail;
        private System.Windows.Forms.Label labelAdresseeMail;
        private System.Windows.Forms.TextBox textBoxAdresseeMail;
        private System.Windows.Forms.Button buttonAddNewEmail;
        private System.Windows.Forms.Button buttonReadEmailFromFile;
        private System.Windows.Forms.ToolTip toolTipAddNewEmail;
        private System.Windows.Forms.ToolTip toolTipReadEmailFromFile;
        private System.Windows.Forms.TextBox textBoxShowAllAdresseeMails;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox textBoxSubkect;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Label labelMailPassword;
        private System.Windows.Forms.TextBox textBoxMailPassword;
        private System.Windows.Forms.Button buttonAttachment;
    }
}