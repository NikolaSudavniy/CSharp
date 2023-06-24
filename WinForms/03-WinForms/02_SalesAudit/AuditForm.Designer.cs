namespace SalesAudit
{
    partial class AuditForm
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
            this.productsGroupBox = new System.Windows.Forms.GroupBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.AddProductInListButton = new System.Windows.Forms.Button();
            this.editProductButton = new System.Windows.Forms.Button();
            this.addNewProductButton = new System.Windows.Forms.Button();
            this.listOfProductsComboBox = new System.Windows.Forms.ComboBox();
            this.salesGroupBox = new System.Windows.Forms.GroupBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.salesListBox = new System.Windows.Forms.ListBox();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.productsGroupBox.SuspendLayout();
            this.salesGroupBox.SuspendLayout();
            this.SuspendLayout();
            
            this.productsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsGroupBox.Controls.Add(this.priceLabel);
            this.productsGroupBox.Controls.Add(this.priceTextBox);
            this.productsGroupBox.Controls.Add(this.AddProductInListButton);
            this.productsGroupBox.Controls.Add(this.editProductButton);
            this.productsGroupBox.Controls.Add(this.addNewProductButton);
            this.productsGroupBox.Controls.Add(this.listOfProductsComboBox);
            this.productsGroupBox.Location = new System.Drawing.Point(39, 31);
            this.productsGroupBox.Name = "productsGroupBox";
            this.productsGroupBox.Size = new System.Drawing.Size(488, 116);
            this.productsGroupBox.TabIndex = 0;
            this.productsGroupBox.TabStop = false;
            this.productsGroupBox.Text = "Select product:";
             
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(332, 25);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "Price";
             
            this.priceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceTextBox.Location = new System.Drawing.Point(369, 22);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 2;
            
            this.AddProductInListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProductInListButton.Location = new System.Drawing.Point(369, 73);
            this.AddProductInListButton.Name = "AddProductInListButton";
            this.AddProductInListButton.Size = new System.Drawing.Size(100, 37);
            this.AddProductInListButton.TabIndex = 5;
            this.AddProductInListButton.Text = "Add product";
            this.AddProductInListButton.UseVisualStyleBackColor = true;
            this.AddProductInListButton.Click += new System.EventHandler(this.AddProductInListButton_Click);
             
            this.editProductButton.Location = new System.Drawing.Point(123, 48);
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.Size = new System.Drawing.Size(100, 37);
            this.editProductButton.TabIndex = 4;
            this.editProductButton.Text = "Edit product";
            this.editProductButton.UseVisualStyleBackColor = true;
            this.editProductButton.Click += new System.EventHandler(this.editProductButton_Click);
             
            this.addNewProductButton.Location = new System.Drawing.Point(17, 48);
            this.addNewProductButton.Name = "addNewProductButton";
            this.addNewProductButton.Size = new System.Drawing.Size(100, 37);
            this.addNewProductButton.TabIndex = 3;
            this.addNewProductButton.Text = "Add new product";
            this.addNewProductButton.UseVisualStyleBackColor = true;
            this.addNewProductButton.Click += new System.EventHandler(this.addNewProductButton_Click);
             
            this.listOfProductsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listOfProductsComboBox.FormattingEnabled = true;
            this.listOfProductsComboBox.Location = new System.Drawing.Point(17, 21);
            this.listOfProductsComboBox.Name = "listOfProductsComboBox";
            this.listOfProductsComboBox.Size = new System.Drawing.Size(309, 21);
            this.listOfProductsComboBox.TabIndex = 0;
            this.listOfProductsComboBox.SelectedIndexChanged += new System.EventHandler(this.listOfProductsComboBox_SelectedIndexChanged);
             
            this.salesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesGroupBox.Controls.Add(this.totalPriceLabel);
            this.salesGroupBox.Controls.Add(this.salesListBox);
            this.salesGroupBox.Controls.Add(this.totalPriceTextBox);
            this.salesGroupBox.Location = new System.Drawing.Point(39, 161);
            this.salesGroupBox.Name = "salesGroupBox";
            this.salesGroupBox.Size = new System.Drawing.Size(488, 277);
            this.salesGroupBox.TabIndex = 1;
            this.salesGroupBox.TabStop = false;
            this.salesGroupBox.Text = "Sales list";
            
            this.totalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(306, 244);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(57, 13);
            this.totalPriceLabel.TabIndex = 1;
            this.totalPriceLabel.Text = "Total price";
             
            this.salesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesListBox.FormattingEnabled = true;
            this.salesListBox.Location = new System.Drawing.Point(17, 29);
            this.salesListBox.Name = "salesListBox";
            this.salesListBox.Size = new System.Drawing.Size(452, 199);
            this.salesListBox.TabIndex = 0;
             
            this.totalPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPriceTextBox.Location = new System.Drawing.Point(369, 241);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.ReadOnly = true;
            this.totalPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalPriceTextBox.TabIndex = 2;
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.salesGroupBox);
            this.Controls.Add(this.productsGroupBox);
            this.Name = "SalesAccountingForm";
            this.Text = "Sales accounting";
            this.productsGroupBox.ResumeLayout(false);
            this.productsGroupBox.PerformLayout();
            this.salesGroupBox.ResumeLayout(false);
            this.salesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox productsGroupBox;
        private System.Windows.Forms.Button editProductButton;
        private System.Windows.Forms.Button addNewProductButton;
        private System.Windows.Forms.ComboBox listOfProductsComboBox;
        private System.Windows.Forms.GroupBox salesGroupBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button AddProductInListButton;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.ListBox salesListBox;
        private System.Windows.Forms.TextBox totalPriceTextBox;
    }
}

