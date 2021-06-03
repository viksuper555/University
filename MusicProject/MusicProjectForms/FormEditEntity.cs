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
    public partial class FormEditEntity : Form
    {
        public object Entity;
        public FormEditEntity(object entity)
        {
            Entity = entity;
            int i = 0;
            foreach(var propInfo in Entity.GetType().GetProperties())
            {
                if (!propInfo.PropertyType.IsPrimitive && propInfo.PropertyType != typeof(string))
                    continue;

                Label label = new Label
                {
                    Text = propInfo.Name,
                    Top = 25 * i + 75,
                    Left = 15,
                    Width = 80,
                    ForeColor = Main.BlueColor
                };

                Control control = new Control();
                if (propInfo.PropertyType == typeof(string))
                    control = new TextBox()
                    {
                        Name = propInfo.Name,
                        Top = 25 * i++ + 75,
                        Width = 100,
                        Left = 100,
                        ForeColor = Main.DarkColor,
                        BorderStyle = BorderStyle.None,
                        TabIndex = 1
                    };
                else if (propInfo.PropertyType == typeof(int) || propInfo.PropertyType == typeof(double))
                    control = new NumericUpDown()
                    {
                        Name = propInfo.Name,
                        Top = 25 * i++ + 75,
                        Width = 100,
                        Maximum = 9999,
                        Left = 100,
                        ForeColor = Main.DarkColor,
                        BorderStyle = BorderStyle.None,
                        TabIndex = 1
                    };

                this.Controls.Add(label);
                this.Controls.Add(control);
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
            foreach (var propInfo in Entity.GetType().GetProperties())
            {
                if (!propInfo.PropertyType.IsPrimitive && propInfo.PropertyType != typeof(string))
                    continue;
                Type type = propInfo.PropertyType;
                propInfo.SetValue(Entity, Convert.ChangeType(Controls.Find(propInfo.Name, true)[0].Text,propInfo.PropertyType));
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
