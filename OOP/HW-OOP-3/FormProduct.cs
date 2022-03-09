using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWFormsApp
{
    public partial class FormProduct : Form
    {
        private Product product;

        public FormProduct()
        {
            InitializeComponent();
        }

        public Product Product
        {
            get => product; 
            set 
            {
                product = value;

                textBoxName.Text = product.Name;
                textBoxNum.Text = product.Price + "";
                textBoxSerial.Text = product.SerialNumber;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Product.Name = textBoxName.Text;
            _ = double.TryParse(textBoxNum.Text, out double result);
            Product.Price = result;
            Product.SerialNumber = textBoxSerial.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
