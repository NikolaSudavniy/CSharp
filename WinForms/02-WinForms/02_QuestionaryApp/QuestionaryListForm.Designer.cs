namespace QuestionaryApp
{
    partial class QuestionaryListForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.questionaryListBox = new System.Windows.Forms.ListBox();
            this.addQuestionaryButton = new System.Windows.Forms.Button();
            this.removeQuestionaryButton = new System.Windows.Forms.Button();
            this.removeAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionaryListBox
            // 
            this.questionaryListBox.FormattingEnabled = true;
            this.questionaryListBox.Location = new System.Drawing.Point(12, 12);
            this.questionaryListBox.Name = "questionaryListBox";
            this.questionaryListBox.Size = new System.Drawing.Size(450, 238);
            this.questionaryListBox.TabIndex = 0;
            // 
            // addQuestionaryButton
            // 
            this.addQuestionaryButton.Location = new System.Drawing.Point(12, 262);
            this.addQuestionaryButton.Name = "addQuestionaryButton";
            this.addQuestionaryButton.Size = new System.Drawing.Size(100, 23);
            this.addQuestionaryButton.TabIndex = 1;
            this.addQuestionaryButton.Text = "Add Questionary";
            this.addQuestionaryButton.UseVisualStyleBackColor = true;
            this.addQuestionaryButton.Click += new System.EventHandler(this.addQuestionaryButton_Click);
            // 
            // removeQuestionaryButton
            // 
            this.removeQuestionaryButton.Location = new System.Drawing.Point(189, 262);
            this.removeQuestionaryButton.Name = "removeQuestionaryButton";
            this.removeQuestionaryButton.Size = new System.Drawing.Size(100, 23);
            this.removeQuestionaryButton.TabIndex = 2;
            this.removeQuestionaryButton.Text = "Remove Questionary";
            this.removeQuestionaryButton.UseVisualStyleBackColor = true;
            this.removeQuestionaryButton.Click += new System.EventHandler(this.removeQuestionaryButton_Click);
            // 
            // removeAllButton
            // 
            this.removeAllButton.Location = new System.Drawing.Point(362, 262);
            this.removeAllButton.Name = "removeAllButton";
            this.removeAllButton.Size = new System.Drawing.Size(100, 23);
            this.removeAllButton.TabIndex = 3;
            this.removeAllButton.Text = "Remove All";
            this.removeAllButton.UseVisualStyleBackColor = true;
            this.removeAllButton.Click += new System.EventHandler(this.removeAllButton_Click);
            // 
            // QuestionaryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 316);
            this.Controls.Add(this.removeAllButton);
            this.Controls.Add(this.removeQuestionaryButton);
            this.Controls.Add(this.addQuestionaryButton);
            this.Controls.Add(this.questionaryListBox);
            this.Name = "QuestionaryListForm";
            this.Text = "Questionary List";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListBox questionaryListBox;
        private System.Windows.Forms.Button addQuestionaryButton;
        private System.Windows.Forms.Button removeQuestionaryButton;
        private System.Windows.Forms.Button removeAllButton;
    }
}