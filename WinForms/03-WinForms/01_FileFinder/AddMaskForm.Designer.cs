namespace FileFinder
{
    partial class AddMaskForm
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
            this.typeMaskLabel = new System.Windows.Forms.Label();
            this.fileMaskTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            this.typeMaskLabel.AutoSize = true;
            this.typeMaskLabel.Location = new System.Drawing.Point(12, 22);
            this.typeMaskLabel.Name = "typeMaskLabel";
            this.typeMaskLabel.Size = new System.Drawing.Size(101, 13);
            this.typeMaskLabel.TabIndex = 0;
            this.typeMaskLabel.Text = "Type new file mask:";
             
            this.fileMaskTextBox.Location = new System.Drawing.Point(119, 19);
            this.fileMaskTextBox.Name = "fileMaskTextBox";
            this.fileMaskTextBox.Size = new System.Drawing.Size(114, 20);
            this.fileMaskTextBox.TabIndex = 1;
             
            this.addButton.Location = new System.Drawing.Point(17, 57);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 35);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
             
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(128, 57);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 35);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(253, 108);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.fileMaskTextBox);
            this.Controls.Add(this.typeMaskLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddMaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add new mask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label typeMaskLabel;
        private System.Windows.Forms.TextBox fileMaskTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}