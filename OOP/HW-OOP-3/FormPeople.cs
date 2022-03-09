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
    public partial class FormPeople : Form
    {
        private PhoneBook phoneBook = new PhoneBook();
        public FormPeople()
        {
            InitializeComponent();
            phoneBook.onChange += PhoneBookChanged;
        }

        private void PhoneBookChanged()
        {
            RefreshListPeople();
        }
        private void RefreshListPeople()
        {
            listBoxPeople.Items.Clear();
            var people = phoneBook.Find(textBoxFilter.Text);
                listBoxPeople.Items.AddRange(people);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var fp = new FormPerson();
            fp.Person = new Person();
            if(fp.ShowDialog() == DialogResult.OK)
            {
                phoneBook.Add(fp.Person);
            }
        }

        private void Delete()
        {
            if (listBoxPeople.SelectedItem == null)
                return;

            if (MessageBox.Show("Are you sure you want to delete it?",
                "Confirm Delete",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                phoneBook.Remove((Person)listBoxPeople.SelectedItem);
            }

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void listBoxPeople_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxPeople.SelectedItem == null)
                return;     
            var fp = new FormPerson();

            fp.Person = listBoxPeople.SelectedItem as Person;

            fp.ShowDialog();
        }

        private void listBoxPeople_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Delete)
                Delete();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            RefreshListPeople();
        }
    }
}
