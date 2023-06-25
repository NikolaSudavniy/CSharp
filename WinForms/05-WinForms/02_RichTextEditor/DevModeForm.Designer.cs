namespace RichTextEditor
{
    partial class DevModeForm
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
            this.richTextBoxDev = new System.Windows.Forms.RichTextBox();
            this.panelDev = new System.Windows.Forms.Panel();
            this.comboBoxDev = new System.Windows.Forms.ComboBox();
            this.menuStripDev = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogDev = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogDev = new System.Windows.Forms.SaveFileDialog();
            this.fontDialogDev = new System.Windows.Forms.FontDialog();
            this.colorDialogDev = new System.Windows.Forms.ColorDialog();
            this.panelDev.SuspendLayout();
            this.menuStripDev.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxDev
            // 
            this.richTextBoxDev.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBoxDev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDev.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBoxDev.Location = new System.Drawing.Point(0, 27);
            this.richTextBoxDev.Name = "richTextBoxDev";
            this.richTextBoxDev.Size = new System.Drawing.Size(800, 423);
            this.richTextBoxDev.TabIndex = 0;
            this.richTextBoxDev.Text = "";
            // 
            // panelDev
            // 
            this.panelDev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDev.Controls.Add(this.comboBoxDev);
            this.panelDev.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDev.Location = new System.Drawing.Point(0, 419);
            this.panelDev.Name = "panelDev";
            this.panelDev.Size = new System.Drawing.Size(800, 31);
            this.panelDev.TabIndex = 1;
            // 
            // comboBoxDev
            // 
            this.comboBoxDev.FormattingEnabled = true;
            this.comboBoxDev.Items.AddRange(new object[] {
            "JavaScript",
            "HTML",
            "CSS"});
            this.comboBoxDev.Location = new System.Drawing.Point(699, 5);
            this.comboBoxDev.Name = "comboBoxDev";
            this.comboBoxDev.Size = new System.Drawing.Size(87, 21);
            this.comboBoxDev.TabIndex = 0;
            this.comboBoxDev.Text = "HTML";
            // 
            // menuStripDev
            // 
            this.menuStripDev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStripDev.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.playToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.backgroundToolStripMenuItem});
            this.menuStripDev.Location = new System.Drawing.Point(0, 0);
            this.menuStripDev.Name = "menuStripDev";
            this.menuStripDev.Size = new System.Drawing.Size(800, 27);
            this.menuStripDev.TabIndex = 2;
            this.menuStripDev.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1});
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(94, 23);
            this.backgroundToolStripMenuItem.Text = "Background";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(127, 24);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // openFileDialogDev
            // 
            this.openFileDialogDev.FileName = "openFileDialog1";
            // 
            // DevModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDev);
            this.Controls.Add(this.richTextBoxDev);
            this.Controls.Add(this.menuStripDev);
            this.MainMenuStrip = this.menuStripDev;
            this.Name = "DevModeForm";
            this.Text = "DevMode TextEditor";
            this.panelDev.ResumeLayout(false);
            this.menuStripDev.ResumeLayout(false);
            this.menuStripDev.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDev;
        private System.Windows.Forms.Panel panelDev;
        private System.Windows.Forms.ComboBox comboBoxDev;
        private System.Windows.Forms.MenuStrip menuStripDev;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogDev;
        private System.Windows.Forms.SaveFileDialog saveFileDialogDev;
        private System.Windows.Forms.FontDialog fontDialogDev;
        private System.Windows.Forms.ColorDialog colorDialogDev;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
    }
}