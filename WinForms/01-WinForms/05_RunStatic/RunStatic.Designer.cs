namespace MyRunStatic
{
    partial class RunStatic
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
            this.omnomnom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // omnomnom
            // 
            this.omnomnom.Image = global::WinForms_05_RunStatic.Properties.Resources._4d5c1c83_cf86_4476_af44_5ea14593c49f;
            this.omnomnom.Location = new System.Drawing.Point(361, 178);
            this.omnomnom.Name = "omnomnom";
            this.omnomnom.Size = new System.Drawing.Size(64, 67);
            this.omnomnom.TabIndex = 0;
            this.omnomnom.Click += new System.EventHandler(this.omnomnom_Click);
            // 
            // RunStatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.omnomnom);
            this.Name = "RunStatic";
            this.Text = "Попробуй поймай";
            this.Load += new System.EventHandler(this.RunStatic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label omnomnom;
    }
}

