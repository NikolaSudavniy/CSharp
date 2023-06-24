namespace TextFileEditor
{
    partial class TextFileEditorForm
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
            this.textForEditingTextBox = new System.Windows.Forms.TextBox();
            this.TextBoxMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UndooToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools = new System.Windows.Forms.ToolStrip();
            this.NewToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.OpenToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.SaveToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CopyToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.CutToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.PasteToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.UndoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ColorToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.BackgroundToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.FontToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.TextBoxMenuStrip.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.Tools.SuspendLayout();
            this.SuspendLayout();
             
            this.textForEditingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textForEditingTextBox.ContextMenuStrip = this.TextBoxMenuStrip;
            this.textForEditingTextBox.Location = new System.Drawing.Point(12, 52);
            this.textForEditingTextBox.Multiline = true;
            this.textForEditingTextBox.Name = "textForEditingTextBox";
            this.textForEditingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textForEditingTextBox.Size = new System.Drawing.Size(531, 256);
            this.textForEditingTextBox.TabIndex = 2;
            this.textForEditingTextBox.TextChanged += new System.EventHandler(this.textForEditingTextBox_TextChanged);
            
            this.TextBoxMenuStrip.Enabled = false;
            this.TextBoxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1,
            this.cutToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.UndooToolStripMenuItem});
            this.TextBoxMenuStrip.Name = "contextMenuStrip1";
            this.TextBoxMenuStrip.Size = new System.Drawing.Size(104, 92);
            
            this.copyToolStripMenuItem1.Enabled = false;
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
             
            this.cutToolStripMenuItem1.Enabled = false;
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.cutToolStripMenuItem1.Text = "Cut";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.cutToolStripMenuItem1_Click);
            
            this.pasteToolStripMenuItem1.Enabled = false;
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            
            this.UndooToolStripMenuItem.Enabled = false;
            this.UndooToolStripMenuItem.Name = "UndooToolStripMenuItem";
            this.UndooToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.UndooToolStripMenuItem.Text = "Undo";
            this.UndooToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem1_Click);
            
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem2});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(555, 24);
            this.MainMenu.TabIndex = 0;
            
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewDocumentToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
             
            this.createNewDocumentToolStripMenuItem.Name = "createNewDocumentToolStripMenuItem";
            this.createNewDocumentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createNewDocumentToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.createNewDocumentToolStripMenuItem.Text = "Create new";
            this.createNewDocumentToolStripMenuItem.Click += new System.EventHandler(this.createNewDocumentToolStripMenuItem_Click);
             
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
             
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
             
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.UndoToolStripMenuItem});
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            
            this.copyToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            
            this.cutToolStripMenuItem.Enabled = false;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            
            this.pasteToolStripMenuItem.Enabled = false;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
             
            this.UndoToolStripMenuItem.Enabled = false;
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.UndoToolStripMenuItem.Text = "Undo";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.textBackgroundToolStripMenuItem,
            this.textToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.colorToolStripMenuItem.Text = "Fore color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            
            this.textBackgroundToolStripMenuItem.Name = "textBackgroundToolStripMenuItem";
            this.textBackgroundToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.textBackgroundToolStripMenuItem.Text = "Background";
            this.textBackgroundToolStripMenuItem.Click += new System.EventHandler(this.textBackgroundToolStripMenuItem_Click);
            
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.textToolStripMenuItem.Text = "Font";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem2.Text = "&Exit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            
            this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripLabel,
            this.OpenToolStripLabel,
            this.SaveToolStripLabel,
            this.toolStripSeparator1,
            this.CopyToolStripLabel,
            this.CutToolStripLabel,
            this.PasteToolStripLabel,
            this.UndoToolStripLabel,
            this.toolStripSeparator2,
            this.ColorToolStripLabel,
            this.BackgroundToolStripLabel,
            this.FontToolStripLabel});
            this.Tools.Location = new System.Drawing.Point(0, 24);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(555, 25);
            this.Tools.TabIndex = 1;
            this.Tools.Text = "Tools";
             
            this.NewToolStripLabel.Name = "NewToolStripLabel";
            this.NewToolStripLabel.Size = new System.Drawing.Size(89, 22);
            this.NewToolStripLabel.Text = "New document";
            this.NewToolStripLabel.Click += new System.EventHandler(this.NewToolStripLabel_Click);
            
            this.OpenToolStripLabel.Name = "OpenToolStripLabel";
            this.OpenToolStripLabel.Size = new System.Drawing.Size(36, 22);
            this.OpenToolStripLabel.Text = "Open";
            this.OpenToolStripLabel.Click += new System.EventHandler(this.OpenToolStripLabel_Click);
             
            this.SaveToolStripLabel.Name = "SaveToolStripLabel";
            this.SaveToolStripLabel.Size = new System.Drawing.Size(31, 22);
            this.SaveToolStripLabel.Text = "Save";
            this.SaveToolStripLabel.Click += new System.EventHandler(this.SaveToolStripLabel_Click);
             
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
             
            this.CopyToolStripLabel.Name = "CopyToolStripLabel";
            this.CopyToolStripLabel.Size = new System.Drawing.Size(35, 22);
            this.CopyToolStripLabel.Text = "Copy";
            this.CopyToolStripLabel.Click += new System.EventHandler(this.CopyToolStripLabel_Click);
            
            this.CutToolStripLabel.Name = "CutToolStripLabel";
            this.CutToolStripLabel.Size = new System.Drawing.Size(26, 22);
            this.CutToolStripLabel.Text = "Cut";
            this.CutToolStripLabel.Click += new System.EventHandler(this.CutToolStripLabel_Click);
             
            this.PasteToolStripLabel.Name = "PasteToolStripLabel";
            this.PasteToolStripLabel.Size = new System.Drawing.Size(35, 22);
            this.PasteToolStripLabel.Text = "Paste";
            this.PasteToolStripLabel.Click += new System.EventHandler(this.PasteToolStripLabel_Click);
            
            this.UndoToolStripLabel.Name = "UndoToolStripLabel";
            this.UndoToolStripLabel.Size = new System.Drawing.Size(36, 22);
            this.UndoToolStripLabel.Text = "Undo";
            this.UndoToolStripLabel.Click += new System.EventHandler(this.CancelToolStripLabel_Click);
            
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
             
            this.ColorToolStripLabel.Name = "ColorToolStripLabel";
            this.ColorToolStripLabel.Size = new System.Drawing.Size(36, 22);
            this.ColorToolStripLabel.Text = "Color";
            this.ColorToolStripLabel.Click += new System.EventHandler(this.ColorToolStripLabel_Click);
            
            this.BackgroundToolStripLabel.Name = "BackgroundToolStripLabel";
            this.BackgroundToolStripLabel.Size = new System.Drawing.Size(71, 22);
            this.BackgroundToolStripLabel.Text = "Background";
            this.BackgroundToolStripLabel.Click += new System.EventHandler(this.BackgroundToolStripLabel_Click);
             
            this.FontToolStripLabel.Name = "FontToolStripLabel";
            this.FontToolStripLabel.Size = new System.Drawing.Size(31, 22);
            this.FontToolStripLabel.Text = "Font";
            this.FontToolStripLabel.Click += new System.EventHandler(this.FontToolStripLabel_Click);
             
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 308);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.textForEditingTextBox);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "TextEditorForm";
            this.TextBoxMenuStrip.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textForEditingTextBox;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textBackgroundToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip TextBoxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem UndooToolStripMenuItem;
        private System.Windows.Forms.ToolStrip Tools;
        private System.Windows.Forms.ToolStripLabel OpenToolStripLabel;
        private System.Windows.Forms.ToolStripLabel SaveToolStripLabel;
        private System.Windows.Forms.ToolStripLabel NewToolStripLabel;
        private System.Windows.Forms.ToolStripLabel CopyToolStripLabel;
        private System.Windows.Forms.ToolStripLabel CutToolStripLabel;
        private System.Windows.Forms.ToolStripLabel PasteToolStripLabel;
        private System.Windows.Forms.ToolStripLabel UndoToolStripLabel;
        private System.Windows.Forms.ToolStripLabel ColorToolStripLabel;
        private System.Windows.Forms.ToolStripLabel FontToolStripLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel BackgroundToolStripLabel;
    }
}

