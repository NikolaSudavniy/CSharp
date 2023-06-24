namespace TextEditor
{
    partial class TextEditorForm
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
            this.loadButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.readOnlyFromFileTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            
            this.loadButton.Location = new System.Drawing.Point(55, 37);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(104, 54);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(272, 37);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(104, 54);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            
            this.readOnlyFromFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.readOnlyFromFileTextBox.Location = new System.Drawing.Point(55, 146);
            this.readOnlyFromFileTextBox.Multiline = true;
            this.readOnlyFromFileTextBox.Name = "readOnlyFromFileTextBox";
            this.readOnlyFromFileTextBox.ReadOnly = true;
            this.readOnlyFromFileTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.readOnlyFromFileTextBox.Size = new System.Drawing.Size(321, 207);
            this.readOnlyFromFileTextBox.TabIndex = 2;
            
            this.AcceptButton = this.loadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 381);
            this.Controls.Add(this.readOnlyFromFileTextBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.loadButton);
            this.Name = "TextEditorForm";
            this.Text = "Text editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextEditorForm_FormClosing);
            this.Load += new System.EventHandler(this.TextEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox readOnlyFromFileTextBox;
    }
}

