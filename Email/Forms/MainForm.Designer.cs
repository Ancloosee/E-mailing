namespace Email
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripMainMenu = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.buttonRemoveAllTask = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuAddNewTask = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRunAllTasks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRunAllTask = new System.Windows.Forms.Button();
            this.menuStripMainMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            this.menuStripMainMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainMenu.Name = "menuStripMainMenu";
            this.menuStripMainMenu.Size = new System.Drawing.Size(792, 24);
            this.menuStripMainMenu.TabIndex = 0;
            this.menuStripMainMenu.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(12, 27);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(76, 60);
            this.buttonAddTask.TabIndex = 1;
            this.buttonAddTask.Text = "Добавить задание";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRemoveAllTask
            // 
            this.buttonRemoveAllTask.Location = new System.Drawing.Point(111, 27);
            this.buttonRemoveAllTask.Name = "buttonRemoveAllTask";
            this.buttonRemoveAllTask.Size = new System.Drawing.Size(76, 60);
            this.buttonRemoveAllTask.TabIndex = 1;
            this.buttonRemoveAllTask.Text = "Удалить все задания";
            this.buttonRemoveAllTask.UseVisualStyleBackColor = true;
            this.buttonRemoveAllTask.Click += new System.EventHandler(this.buttonRemoveAllTask_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Email Рассылка";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuAddNewTask,
            this.toolStripMenuItemRunAllTasks,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 76);
            this.contextMenuStrip1.Text = "Добавить новое задание";
            this.contextMenuStrip1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip1_MouseClick);
            // 
            // toolStripMenuAddNewTask
            // 
            this.toolStripMenuAddNewTask.Name = "toolStripMenuAddNewTask";
            this.toolStripMenuAddNewTask.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuAddNewTask.Text = "Добавить новое задание";
            this.toolStripMenuAddNewTask.Click += new System.EventHandler(this.toolStripMenuAddNewTask_Click);
            // 
            // toolStripMenuItemRunAllTasks
            // 
            this.toolStripMenuItemRunAllTasks.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemRunAllTasks.Image")));
            this.toolStripMenuItemRunAllTasks.Name = "toolStripMenuItemRunAllTasks";
            this.toolStripMenuItemRunAllTasks.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItemRunAllTasks.Text = "Запустить все задания";
            this.toolStripMenuItemRunAllTasks.Click += new System.EventHandler(this.toolStripMenuItemRunAllTasks_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // buttonRunAllTask
            // 
            this.buttonRunAllTask.Location = new System.Drawing.Point(206, 27);
            this.buttonRunAllTask.Name = "buttonRunAllTask";
            this.buttonRunAllTask.Size = new System.Drawing.Size(76, 60);
            this.buttonRunAllTask.TabIndex = 1;
            this.buttonRunAllTask.Text = "Запустить все задания";
            this.buttonRunAllTask.UseVisualStyleBackColor = true;
            this.buttonRunAllTask.Click += new System.EventHandler(this.buttonRunAllTask_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(792, 451);
            this.Controls.Add(this.buttonRunAllTask);
            this.Controls.Add(this.buttonRemoveAllTask);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.menuStripMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStripMainMenu;
            this.Name = "MainForm";
            this.Text = "Рассылка Email ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStripMainMenu.ResumeLayout(false);
            this.menuStripMainMenu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainMenu;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Button buttonRemoveAllTask;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAddNewTask;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRunAllTasks;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button buttonRunAllTask;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}