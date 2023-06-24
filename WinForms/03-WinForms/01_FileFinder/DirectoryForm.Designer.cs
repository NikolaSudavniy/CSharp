namespace FileFinder
{
    partial class DirectoryForm
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
            this.findButton = new System.Windows.Forms.Button();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.directoryListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
             
            this.findButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.findButton.Location = new System.Drawing.Point(0, 0);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(672, 54);
            this.findButton.TabIndex = 0;
            this.findButton.Text = "GO";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
             
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.HorizontalScrollbar = true;
            this.filesListBox.Location = new System.Drawing.Point(337, 60);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(335, 381);
            this.filesListBox.TabIndex = 2;
            this.filesListBox.SelectedIndexChanged += new System.EventHandler(this.filesListBox_SelectedIndexChanged);
             
            this.directoryListBox.FormattingEnabled = true;
            this.directoryListBox.HorizontalScrollbar = true;
            this.directoryListBox.Location = new System.Drawing.Point(0, 60);
            this.directoryListBox.Name = "directoryListBox";
            this.directoryListBox.Size = new System.Drawing.Size(331, 381);
            this.directoryListBox.TabIndex = 1;
            this.directoryListBox.SelectedIndexChanged += new System.EventHandler(this.directoryListBox_SelectedIndexChanged);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.directoryListBox);
            this.Controls.Add(this.filesListBox);
            this.Controls.Add(this.findButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DirectoryForm";
            this.Text = "Directories and files";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.ListBox directoryListBox;
    }
}