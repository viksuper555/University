using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                Control control = new Control();

                Label label = new Label
                {
                    Text = propInfo.Name,
                    Top = 25 * i + 75,
                    Left = 15,
                    Width = 80,
                    ForeColor = Main.BlueColor
                };

                if (!propInfo.PropertyType.IsPrimitive && propInfo.PropertyType != typeof(string))
                {
                    var a = new CheckedListBox()
                        {
                            Name = propInfo.Name,
                            Top = 25 * i++ + 75,
                            Left = 100,
                            ForeColor = Main.DarkColor,
                            BorderStyle = BorderStyle.None,
                            Height = 50,
                            TabIndex = 1,
                        };
                    control = a;
                    if (propInfo.PropertyType == typeof(List<Song>))
                    {
                        foreach (var item in (List<Song>)propInfo.GetValue(Entity))
                            a.Items.Add(item,true);

                        foreach (var item in Main.Songs.Except((List<Song>)propInfo.GetValue(Entity)))
                            a.Items.Add(item, false);
                    }
                    else
                        continue;
                }

                if (propInfo.PropertyType == typeof(string))
                    control = new TextBox()
                    {
                        Name = propInfo.Name,
                        Top = 25 * i++ + 75,
                        Width = 100,
                        Left = 100,
                        ForeColor = Main.DarkColor,
                        BorderStyle = BorderStyle.None,
                        TabIndex = 1,
                        Text = (string)propInfo.GetValue(Entity)
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
                        TabIndex = 1,
                        Value = Convert.ToDecimal(propInfo.GetValue(Entity))
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            foreach (var propInfo in Entity.GetType().GetProperties())
            {
                var control = Controls.Find(propInfo.Name, true).FirstOrDefault();

                if (control == null) continue;
                if (propInfo.PropertyType.IsPrimitive || propInfo.PropertyType == typeof(string))
                {
                    Type type = propInfo.PropertyType;
                    propInfo.SetValue(Entity, Convert.ChangeType(control.Text, propInfo.PropertyType));
                }
                else
                {
                    CheckedListBox listBox = (CheckedListBox)control;
                    List<object> list = listBox.CheckedItems.OfType<object>().ToList();
                    propInfo.SetValue(Entity, list.Select(item => Convert.ChangeType(item, propInfo.PropertyType)).ToList());
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
