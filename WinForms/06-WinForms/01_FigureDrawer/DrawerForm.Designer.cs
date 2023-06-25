namespace FigureDrawer
{
    partial class DrawerForm
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
            this.DrawBox = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.Button();
            this.ShapeComboBox = new System.Windows.Forms.ComboBox();
            this.Undo = new System.Windows.Forms.Button();
            this.Redo = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).BeginInit();
            this.SuspendLayout();
            
            this.DrawBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawBox.Location = new System.Drawing.Point(0, 0);
            this.DrawBox.Name = "DrawBox";
            this.DrawBox.Size = new System.Drawing.Size(800, 450);
            this.DrawBox.TabIndex = 0;
            this.DrawBox.TabStop = false;
            this.DrawBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawBox_MouseDown);
            this.DrawBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawBox_MouseUp);

            this.ShapeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShapeComboBox.FormattingEnabled = true;
            this.ShapeComboBox.Items.AddRange(new object[] {
            "None",
            "Rectangle",
            "Circle",
            "Triangle"});
            this.ShapeComboBox.Location = new System.Drawing.Point(12, 12);
            this.ShapeComboBox.Name = "ShapeComboBox";
            this.ShapeComboBox.Size = new System.Drawing.Size(121, 21);
            this.ShapeComboBox.TabIndex = 2;
            this.ShapeComboBox.SelectedIndexChanged += new System.EventHandler(this.shapeComboBox_SelectedIndexChanged);

            this.Save.Location = new System.Drawing.Point(382, 10);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.saveButton_Click);
            
            this.Undo.Location = new System.Drawing.Point(139, 10);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(75, 23);
            this.Undo.TabIndex = 3;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.undoButton_Click);
            
            this.Redo.Location = new System.Drawing.Point(220, 10);
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(75, 23);
            this.Redo.TabIndex = 4;
            this.Redo.Text = "Redo";
            this.Redo.UseVisualStyleBackColor = true;
            this.Redo.Click += new System.EventHandler(this.redoButton_Click);
             
            this.Clear.Location = new System.Drawing.Point(301, 10);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.clearButton_Click);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Redo);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.ShapeComboBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.DrawBox);
            this.Name = "DrawerForm";
            this.Text = "Geometry Drawer";
            this.Load += new System.EventHandler(this.DrawerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox DrawBox;
        private System.Windows.Forms.ComboBox ShapeComboBox;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button Redo;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Save;
    }
}