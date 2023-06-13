namespace ProgressBarLoader
{
    partial class ProgressBarLoaderForm
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
            this.openFileGroupBox = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textFileRadioButton = new System.Windows.Forms.RadioButton();
            this.byteFileRadioButton = new System.Windows.Forms.RadioButton();
            this.openButton = new System.Windows.Forms.Button();
            this.openFileGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileGroupBox
            // 
            this.openFileGroupBox.Controls.Add(this.progressBar);
            this.openFileGroupBox.Controls.Add(this.textFileRadioButton);
            this.openFileGroupBox.Controls.Add(this.byteFileRadioButton);
            this.openFileGroupBox.Controls.Add(this.openButton);
            this.openFileGroupBox.Location = new System.Drawing.Point(26, 24);
            this.openFileGroupBox.Name = "openFileGroupBox";
            this.openFileGroupBox.Size = new System.Drawing.Size(218, 161);
            this.openFileGroupBox.TabIndex = 0;
            this.openFileGroupBox.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(22, 128);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(169, 10);
            this.progressBar.TabIndex = 3;
            // 
            // textFileRadioButton
            // 
            this.textFileRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textFileRadioButton.AutoSize = true;
            this.textFileRadioButton.Location = new System.Drawing.Point(130, 32);
            this.textFileRadioButton.Name = "textFileRadioButton";
            this.textFileRadioButton.Size = new System.Drawing.Size(62, 17);
            this.textFileRadioButton.TabIndex = 1;
            this.textFileRadioButton.Text = "Text file";
            this.textFileRadioButton.UseVisualStyleBackColor = true;
            // 
            // byteFileRadioButton
            // 
            this.byteFileRadioButton.AutoSize = true;
            this.byteFileRadioButton.Checked = true;
            this.byteFileRadioButton.Location = new System.Drawing.Point(22, 32);
            this.byteFileRadioButton.Name = "byteFileRadioButton";
            this.byteFileRadioButton.Size = new System.Drawing.Size(62, 17);
            this.byteFileRadioButton.TabIndex = 0;
            this.byteFileRadioButton.TabStop = true;
            this.byteFileRadioButton.Text = "Byte file";
            this.byteFileRadioButton.UseVisualStyleBackColor = true;
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.openButton.Location = new System.Drawing.Point(54, 72);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(100, 39);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // ProgressBarLoaderForm
            // 
            this.AcceptButton = this.openButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(271, 205);
            this.Controls.Add(this.openFileGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ProgressBarLoaderForm";
            this.Text = "Load and open file";
            this.Load += new System.EventHandler(this.ProgressBarLoaderForm_Load);
            this.openFileGroupBox.ResumeLayout(false);
            this.openFileGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox openFileGroupBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.RadioButton textFileRadioButton;
        private System.Windows.Forms.RadioButton byteFileRadioButton;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}