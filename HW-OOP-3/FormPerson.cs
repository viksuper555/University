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
    public partial class FormPerson : Form
    {
        private Person person;
        public Person Person
        {
            get => person;
            set
            {
                person = value;
                foreach (var product in person.Products)
                    listBoxProducts.Items.Add(product);
                textBoxName.Text = person.Name;
                textBoxNum.Text = person.Num;
                person.OnChangePerson += ProductsChanged;
            }
        }
        public FormPerson()
        {
            InitializeComponent();
        }
        private void ProductsChanged()
        {
            RefreshListProducts();
        }
        private void RefreshListProducts()
        {
            listBoxProducts.Items.Clear();
            foreach(var product in Person.Products)
                listBoxProducts.Items.Add(product);
        }

        private void Delete()
        {
            if (listBoxProducts.SelectedItem == null)
                return;

            if (MessageBox.Show("Are you sure you want to delete it?",
                "Confirm Delete",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Person.Remove((Product)listBoxProducts.SelectedItem);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Person.Name = textBoxName.Text;
            Person.Num = textBoxNum.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var fp = new FormProduct();
            fp.Product = new Product();

            if (fp.ShowDialog() == DialogResult.OK)
            {
                Person.Add(fp.Product);
            }
        }
        private void listBoxProducts_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem == null)
                return;
            var fp = new FormProduct();

            fp.Product = listBoxProducts.SelectedItem as Product;

            fp.ShowDialog();
        }
        private void listBoxProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
                Delete();
        }
        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
