using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesAudit
{
    public partial class CreateProductForm : Form
    {
        private Product _product;

        /// <summary>
        /// Create form for creating new or editing existing product.
        /// </summary>
        /// <param name="product">ref on product that will be creating or editing</param>
        /// <param name="addNew">set true if u want to create new product or set false if u want to edit existing product</param>
        public CreateProductForm(Product product, bool addNew)
        {
            InitializeComponent();

            _product = product;

            if (!addNew)
            {
                nameTextBox.Text = _product.Name;
                featureTextBox.Text = _product.Feature;
                descriptionTextBox.Text = _product.Description;
                priceTextBox.Text = _product.Price;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _product.Name = nameTextBox.Text;
            _product.Feature = featureTextBox.Text;
            _product.Description = descriptionTextBox.Text;

            try
            {
                _product.Price = priceTextBox.Text;
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                priceTextBox.Clear();
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void CreateProductForm_Load(object sender, EventArgs e)
        {
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            _product = null;
            DialogResult = DialogResult.Cancel;
        }
    }
}
