namespace _06_07_Date
{
    partial class DateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.enteredDataLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.timeSpanGroupBox = new System.Windows.Forms.GroupBox();
            this.timeSpanLabel = new System.Windows.Forms.Label();
            this.inSecondRadioButton = new System.Windows.Forms.RadioButton();
            this.inMinutesRadioButton = new System.Windows.Forms.RadioButton();
            this.inDaysRadioButton = new System.Windows.Forms.RadioButton();
            this.inMonthsRadioButton = new System.Windows.Forms.RadioButton();
            this.inYearsRadioButton = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dayOfWeekLabel = new System.Windows.Forms.Label();
            this.timeSpanGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // enteredDataLabel
            // 
            this.enteredDataLabel.AutoSize = true;
            this.enteredDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enteredDataLabel.Location = new System.Drawing.Point(22, 32);
            this.enteredDataLabel.Name = "enteredDataLabel";
            this.enteredDataLabel.Size = new System.Drawing.Size(104, 20);
            this.enteredDataLabel.TabIndex = 0;
            this.enteredDataLabel.Text = "Choose date:";
            this.enteredDataLabel.Click += new System.EventHandler(this.label1_Click);
            this.enteredDataLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.enteredDataLabel_MouseClick);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(22, 105);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(100, 20);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "Day of week:";
            this.resultLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // timeSpanGroupBox
            // 
            this.timeSpanGroupBox.Controls.Add(this.timeSpanLabel);
            this.timeSpanGroupBox.Controls.Add(this.inSecondRadioButton);
            this.timeSpanGroupBox.Controls.Add(this.inMinutesRadioButton);
            this.timeSpanGroupBox.Controls.Add(this.inDaysRadioButton);
            this.timeSpanGroupBox.Controls.Add(this.inMonthsRadioButton);
            this.timeSpanGroupBox.Controls.Add(this.inYearsRadioButton);
            this.timeSpanGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeSpanGroupBox.Location = new System.Drawing.Point(20, 177);
            this.timeSpanGroupBox.Name = "timeSpanGroupBox";
            this.timeSpanGroupBox.Size = new System.Drawing.Size(319, 183);
            this.timeSpanGroupBox.TabIndex = 3;
            this.timeSpanGroupBox.TabStop = false;
            this.timeSpanGroupBox.Text = "Time left to entered date:";
            this.timeSpanGroupBox.Enter += new System.EventHandler(this.timeSpanGroupBox_Enter);
            // 
            // timeSpanLabel
            // 
            this.timeSpanLabel.Location = new System.Drawing.Point(204, 1);
            this.timeSpanLabel.Name = "timeSpanLabel";
            this.timeSpanLabel.Size = new System.Drawing.Size(125, 20);
            this.timeSpanLabel.TabIndex = 4;
            this.timeSpanLabel.Text = "0";
            this.timeSpanLabel.Click += new System.EventHandler(this.timeSpanLabel_Click);
            // 
            // inSecondRadioButton
            // 
            this.inSecondRadioButton.AutoSize = true;
            this.inSecondRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inSecondRadioButton.Location = new System.Drawing.Point(6, 27);
            this.inSecondRadioButton.Name = "inSecondRadioButton";
            this.inSecondRadioButton.Size = new System.Drawing.Size(94, 21);
            this.inSecondRadioButton.TabIndex = 0;
            this.inSecondRadioButton.TabStop = true;
            this.inSecondRadioButton.Text = "in seconds";
            this.inSecondRadioButton.UseVisualStyleBackColor = true;
            this.inSecondRadioButton.CheckedChanged += new System.EventHandler(this.inSecondRadioButton_CheckedChanged);
            // 
            // inMinutesRadioButton
            // 
            this.inMinutesRadioButton.AutoSize = true;
            this.inMinutesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inMinutesRadioButton.Location = new System.Drawing.Point(6, 55);
            this.inMinutesRadioButton.Name = "inMinutesRadioButton";
            this.inMinutesRadioButton.Size = new System.Drawing.Size(90, 21);
            this.inMinutesRadioButton.TabIndex = 0;
            this.inMinutesRadioButton.TabStop = true;
            this.inMinutesRadioButton.Text = "in minutes";
            this.inMinutesRadioButton.UseVisualStyleBackColor = true;
            this.inMinutesRadioButton.CheckedChanged += new System.EventHandler(this.inMinutesRadioButton_CheckedChanged);
            // 
            // inDaysRadioButton
            // 
            this.inDaysRadioButton.AutoSize = true;
            this.inDaysRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inDaysRadioButton.Location = new System.Drawing.Point(6, 85);
            this.inDaysRadioButton.Name = "inDaysRadioButton";
            this.inDaysRadioButton.Size = new System.Drawing.Size(71, 21);
            this.inDaysRadioButton.TabIndex = 0;
            this.inDaysRadioButton.TabStop = true;
            this.inDaysRadioButton.Text = "in days";
            this.inDaysRadioButton.UseVisualStyleBackColor = true;
            this.inDaysRadioButton.CheckedChanged += new System.EventHandler(this.inDaysRadioButton_CheckedChanged);
            // 
            // inMonthsRadioButton
            // 
            this.inMonthsRadioButton.AutoSize = true;
            this.inMonthsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inMonthsRadioButton.Location = new System.Drawing.Point(6, 115);
            this.inMonthsRadioButton.Name = "inMonthsRadioButton";
            this.inMonthsRadioButton.Size = new System.Drawing.Size(87, 21);
            this.inMonthsRadioButton.TabIndex = 0;
            this.inMonthsRadioButton.TabStop = true;
            this.inMonthsRadioButton.Text = "in months";
            this.inMonthsRadioButton.UseVisualStyleBackColor = true;
            this.inMonthsRadioButton.CheckedChanged += new System.EventHandler(this.inMonthsRadioButton_CheckedChanged);
            // 
            // inYearsRadioButton
            // 
            this.inYearsRadioButton.AutoSize = true;
            this.inYearsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inYearsRadioButton.Location = new System.Drawing.Point(6, 143);
            this.inYearsRadioButton.Name = "inYearsRadioButton";
            this.inYearsRadioButton.Size = new System.Drawing.Size(76, 21);
            this.inYearsRadioButton.TabIndex = 0;
            this.inYearsRadioButton.Text = "in years";
            this.inYearsRadioButton.UseVisualStyleBackColor = true;
            this.inYearsRadioButton.CheckedChanged += new System.EventHandler(this.inYearsRadioButton_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(143, 32);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dayOfWeekLabel
            // 
            this.dayOfWeekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayOfWeekLabel.Location = new System.Drawing.Point(139, 106);
            this.dayOfWeekLabel.Name = "dayOfWeekLabel";
            this.dayOfWeekLabel.Size = new System.Drawing.Size(149, 20);
            this.dayOfWeekLabel.TabIndex = 4;
            this.dayOfWeekLabel.Text = "0";
            this.dayOfWeekLabel.Click += new System.EventHandler(this.timeSpanLabel_Click);
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 413);
            this.Controls.Add(this.dayOfWeekLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.timeSpanGroupBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.enteredDataLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DateForm";
            this.Text = "Date checker";
            this.Load += new System.EventHandler(this.DataTimeForm_Load);
            this.timeSpanGroupBox.ResumeLayout(false);
            this.timeSpanGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label enteredDataLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.GroupBox timeSpanGroupBox;
        private System.Windows.Forms.RadioButton inSecondRadioButton;
        private System.Windows.Forms.RadioButton inMinutesRadioButton;
        private System.Windows.Forms.RadioButton inDaysRadioButton;
        private System.Windows.Forms.RadioButton inMonthsRadioButton;
        private System.Windows.Forms.RadioButton inYearsRadioButton;
        private System.Windows.Forms.Label timeSpanLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label dayOfWeekLabel;
    }
}

