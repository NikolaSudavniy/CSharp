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
    public partial class AuditForm : Form
    {
        private Product product;

        public AuditForm()
        {
            InitializeComponent();

            priceTextBox.Text = string.Empty;
            listOfProductsComboBox.SelectedItem = null;

            if (listOfProductsComboBox.SelectedIndex != -1)
            {
                decimal total = 0;

                foreach (var item in listOfProductsComboBox.Items)
                    total += ((Product)item).PriceInDecimal;

                totalPriceTextBox.Text = total.ToString();
            }
        }

        private void listOfProductsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOfProductsComboBox.SelectedItem != null)
                priceTextBox.Text = ((Product)listOfProductsComboBox.SelectedItem).Price;
            else
                priceTextBox.Text = string.Empty;
        }

        private void addNewProductButton_Click(object sender, EventArgs e)
        {
            product = new Product();
            var createItem = new CreateProductForm(product, true);

            if (createItem.ShowDialog() == DialogResult.OK)
                listOfProductsComboBox.Items.Add(product);
        }

        private void editProductButton_Click(object sender, EventArgs e)
        {
            if (listOfProductsComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Choose item first");
                return;
            }

            int i = listOfProductsComboBox.SelectedIndex;

            product = (Product)listOfProductsComboBox.Items[i];

            var editItem = new CreateProductForm(product, false);
            editItem.ShowDialog();

            listOfProductsComboBox.Items.RemoveAt(i);
            listOfProductsComboBox.Items.Insert(i, product);
            listOfProductsComboBox.SelectedIndex = i;
        }

        private void AddProductInListButton_Click(object sender, EventArgs e)
        {
            if (listOfProductsComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Choose item first");
                return;
            }

            Product newItem = (Product)listOfProductsComboBox.SelectedItem;
            salesListBox.Items.Add(newItem);

            decimal.TryParse(totalPriceTextBox.Text, out decimal total);

            totalPriceTextBox.Text = (total + newItem.PriceInDecimal).ToString();
        }
    }
}
