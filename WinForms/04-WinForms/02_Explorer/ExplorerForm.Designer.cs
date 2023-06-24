namespace Explorer
{
    partial class ExplorerForm
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
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllInsideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setStartFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.ShowInsideToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.SetstartfolderToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.FoldersAndFilesBox = new System.Windows.Forms.ListBox();
            this.FoldersTreeView = new System.Windows.Forms.TreeView();
            this.FoldersMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInsideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setStartFolderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.FoldersMenuStrip.SuspendLayout();
            this.SuspendLayout();

            this.AddressTextBox.Location = new System.Drawing.Point(333, 54);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.ReadOnly = true;
            this.AddressTextBox.Size = new System.Drawing.Size(395, 20);
            this.AddressTextBox.TabIndex = 2;

            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exetToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(736, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";

            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllInsideToolStripMenuItem,
            this.setStartFolderToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
 
            this.showAllInsideToolStripMenuItem.Name = "showAllInsideToolStripMenuItem";
            this.showAllInsideToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.showAllInsideToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.showAllInsideToolStripMenuItem.Text = "Show all inside";
            this.showAllInsideToolStripMenuItem.Click += new System.EventHandler(this.showAllInsideToolStripMenuItem_Click);

            this.setStartFolderToolStripMenuItem.Name = "setStartFolderToolStripMenuItem";
            this.setStartFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.setStartFolderToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.setStartFolderToolStripMenuItem.Text = "Set start folder";
            this.setStartFolderToolStripMenuItem.Click += new System.EventHandler(this.setStartFolderToolStripMenuItem_Click);

            this.exetToolStripMenuItem.Name = "exetToolStripMenuItem";
            this.exetToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exetToolStripMenuItem.Text = "&Exit";
            this.exetToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowInsideToolStripLabel,
            this.SetstartfolderToolStripLabel,
            this.toolStripSeparator1,
            this.ExitToolStripLabel});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(736, 25);
            this.toolStrip.TabIndex = 1;

            this.ShowInsideToolStripLabel.Name = "ShowInsideToolStripLabel";
            this.ShowInsideToolStripLabel.Size = new System.Drawing.Size(70, 22);
            this.ShowInsideToolStripLabel.Text = "Show inside";
            this.ShowInsideToolStripLabel.Click += new System.EventHandler(this.ShowInsideToolStripLabel_Click);

            this.SetstartfolderToolStripLabel.Name = "SetstartfolderToolStripLabel";
            this.SetstartfolderToolStripLabel.Size = new System.Drawing.Size(83, 22);
            this.SetstartfolderToolStripLabel.Text = "Set start folder";
            this.SetstartfolderToolStripLabel.Click += new System.EventHandler(this.SetstartfolderToolStripLabel_Click);

            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);

            this.ExitToolStripLabel.Name = "ExitToolStripLabel";
            this.ExitToolStripLabel.Size = new System.Drawing.Size(25, 22);
            this.ExitToolStripLabel.Text = "Exit";
            this.ExitToolStripLabel.Click += new System.EventHandler(this.ExitToolStripLabel_Click);
  
            this.FoldersAndFilesBox.FormattingEnabled = true;
            this.FoldersAndFilesBox.HorizontalScrollbar = true;
            this.FoldersAndFilesBox.Location = new System.Drawing.Point(333, 80);
            this.FoldersAndFilesBox.Name = "FoldersAndFilesBox";
            this.FoldersAndFilesBox.Size = new System.Drawing.Size(395, 329);
            this.FoldersAndFilesBox.TabIndex = 4;
 
            this.FoldersTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FoldersTreeView.ContextMenuStrip = this.FoldersMenuStrip;
            this.FoldersTreeView.Location = new System.Drawing.Point(12, 81);
            this.FoldersTreeView.Name = "FoldersTreeView";
            this.FoldersTreeView.Size = new System.Drawing.Size(315, 328);
            this.FoldersTreeView.TabIndex = 3;
 
            this.FoldersMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInsideToolStripMenuItem,
            this.setStartFolderToolStripMenuItem1});
            this.FoldersMenuStrip.Name = "FoldersMenuStrip";
            this.FoldersMenuStrip.Size = new System.Drawing.Size(151, 48);

            this.showInsideToolStripMenuItem.Name = "showInsideToolStripMenuItem";
            this.showInsideToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.showInsideToolStripMenuItem.Text = "Show inside";
            this.showInsideToolStripMenuItem.Click += new System.EventHandler(this.showInsideToolStripMenuItem_Click);

            this.setStartFolderToolStripMenuItem1.Name = "setStartFolderToolStripMenuItem1";
            this.setStartFolderToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.setStartFolderToolStripMenuItem1.Text = "Set start folder";
            this.setStartFolderToolStripMenuItem1.Click += new System.EventHandler(this.setStartFolderToolStripMenuItem1_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 419);
            this.Controls.Add(this.FoldersTreeView);
            this.Controls.Add(this.FoldersAndFilesBox);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Directies";
            this.Text = "Directory tree";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.FoldersMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem exetToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ListBox FoldersAndFilesBox;
        private System.Windows.Forms.ToolStripLabel ExitToolStripLabel;
        private System.Windows.Forms.TreeView FoldersTreeView;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllInsideToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel ShowInsideToolStripLabel;
        private System.Windows.Forms.ContextMenuStrip FoldersMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showInsideToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem setStartFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel SetstartfolderToolStripLabel;
        private System.Windows.Forms.ToolStripMenuItem setStartFolderToolStripMenuItem1;
    }
}