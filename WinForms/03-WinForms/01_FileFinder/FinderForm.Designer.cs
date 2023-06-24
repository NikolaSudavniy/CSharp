namespace FileFinder
{
    partial class FinderForm
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
            this.chooseFolderButton = new System.Windows.Forms.Button();
            this.maskLabel = new System.Windows.Forms.Label();
            this.masksCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.folderLabel = new System.Windows.Forms.Label();
            this.folderPathTextBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.addNewMaskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            this.chooseFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseFolderButton.Location = new System.Drawing.Point(241, 57);
            this.chooseFolderButton.Name = "chooseFolderButton";
            this.chooseFolderButton.Size = new System.Drawing.Size(105, 35);
            this.chooseFolderButton.TabIndex = 2;
            this.chooseFolderButton.Text = "Choose folder";
            this.chooseFolderButton.UseVisualStyleBackColor = true;
            this.chooseFolderButton.Click += new System.EventHandler(this.chooseFolderButton_Click);
            
            this.maskLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskLabel.AutoSize = true;
            this.maskLabel.Location = new System.Drawing.Point(12, 123);
            this.maskLabel.Name = "maskLabel";
            this.maskLabel.Size = new System.Drawing.Size(95, 13);
            this.maskLabel.TabIndex = 3;
            this.maskLabel.Text = "Choose one mask:";
             
            this.masksCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masksCheckedListBox.FormattingEnabled = true;
            this.masksCheckedListBox.Location = new System.Drawing.Point(15, 143);
            this.masksCheckedListBox.MultiColumn = true;
            this.masksCheckedListBox.Name = "masksCheckedListBox";
            this.masksCheckedListBox.Size = new System.Drawing.Size(331, 124);
            this.masksCheckedListBox.TabIndex = 4;
            
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(12, 25);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(42, 13);
            this.folderLabel.TabIndex = 0;
            this.folderLabel.Text = "Folder: ";
             
            this.folderPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderPathTextBox.Location = new System.Drawing.Point(60, 22);
            this.folderPathTextBox.Name = "folderPathTextBox";
            this.folderPathTextBox.Size = new System.Drawing.Size(286, 20);
            this.folderPathTextBox.TabIndex = 1;
             
            this.findButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.findButton.Location = new System.Drawing.Point(241, 291);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(105, 35);
            this.findButton.TabIndex = 6;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
             
            this.addNewMaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNewMaskButton.Location = new System.Drawing.Point(15, 291);
            this.addNewMaskButton.Name = "addNewMaskButton";
            this.addNewMaskButton.Size = new System.Drawing.Size(105, 35);
            this.addNewMaskButton.TabIndex = 5;
            this.addNewMaskButton.Text = "Add new mask";
            this.addNewMaskButton.UseVisualStyleBackColor = true;
            this.addNewMaskButton.Click += new System.EventHandler(this.addNewMaskButton_Click);
             
            this.AcceptButton = this.findButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 342);
            this.Controls.Add(this.folderPathTextBox);
            this.Controls.Add(this.folderLabel);
            this.Controls.Add(this.masksCheckedListBox);
            this.Controls.Add(this.maskLabel);
            this.Controls.Add(this.addNewMaskButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.chooseFolderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FinderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FinderForm";
            this.Load += new System.EventHandler(this.FinderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button chooseFolderButton;
        private System.Windows.Forms.Label maskLabel;
        private System.Windows.Forms.CheckedListBox masksCheckedListBox;
        private System.Windows.Forms.Label folderLabel;
        private System.Windows.Forms.TextBox folderPathTextBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button addNewMaskButton;
    }
}

