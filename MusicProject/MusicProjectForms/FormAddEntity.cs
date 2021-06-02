using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MusicProject;

namespace MusicProjectForms
{
    public partial class FormAddEntity : Form
    {
        object entity = new object();
        public FormAddEntity(string fullTypeName)
        {
            Type type = Type.GetType(fullTypeName);
            if (type != null)
                entity =  Activator.CreateInstance(type);
            else
            {
                foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                {
                    type = asm.GetType(fullTypeName);
                    if (type != null)
                    {
                        entity = Activator.CreateInstance(type);
                        break;
                    }
                }
            }

            int i = 0;
            foreach(var property in entity.GetType().GetProperties())
            {
                if (!property.PropertyType.IsPrimitive && property.PropertyType != typeof(string))
                    continue;

                Label label = new Label
                {
                    Text = property.Name,
                    Top = 25 * i + 75,
                    Left = 15,
                    Width = 80,
                    ForeColor = Main.BlueColor
                };

                TextBox textBox = new TextBox()
                {
                    Top = 25 * i++ + 75,
                    Left = 100,
                    ForeColor = Main.DarkColor,
                    BorderStyle = BorderStyle.None,
                    Tag = property.Name
                };
                

                this.Controls.Add(label);
                this.Controls.Add(textBox);
            }
            
            InitializeComponent();
        }

        private bool mouseDown;
        private Point lastLocation;

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
