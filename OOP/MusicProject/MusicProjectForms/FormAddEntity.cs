using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MusicProject;

namespace MusicProjectForms
{
    public partial class FormAddEntity : Form
    {
        public object Entity = new object();
        private string imagePath;
        private string soundPath;
        private Label label;
        public FormAddEntity(string fullTypeName)
        {
            Type type = Type.GetType(fullTypeName);
            if (type != null)
                Entity =  Activator.CreateInstance(type);
            else
            {
                foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                {
                    type = asm.GetType(fullTypeName);
                    if (type != null)
                    {
                        Entity = Activator.CreateInstance(type);
                        break;
                    }
                }
            }
            int i = 0;
            foreach(var propInfo in Entity.GetType().GetProperties())
            {
                Control control = new Control();

                label = new Label
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
                        Top = 25 * i + 75,
                        Left = 100,
                        ForeColor = Main.DarkColor,
                        BorderStyle = BorderStyle.None,
                        Height = 100,
                        TabIndex = 1,
                        CheckOnClick = true
                    };
                    i += 4;
                    control = a;
                    //TODO: Make this generic, to find Main lists by PropertyType. But we aren't hired by NASA yet.
                    //If this is generic, saving could also become generic and the relationship information would become dynamic.
                    if (propInfo.PropertyType == typeof(List<Song>))
                    {
                        foreach (var item in Main.Songs)
                            a.Items.Add(item);
                    }
                    else if (propInfo.PropertyType == typeof(List<Album>))
                    {
                        foreach (var item in Main.Albums)
                            a.Items.Add(item);
                    }
                    else if (propInfo.PropertyType == typeof(List<Artist>))
                    {
                        foreach (var item in Main.Artists)
                            a.Items.Add(item);
                    }
                    else if (propInfo.PropertyType == typeof(List<Group>))
                    {
                        foreach (var item in Main.Groups)
                            a.Items.Add(item);
                    }
                    else if (propInfo.PropertyType == typeof(Album))
                    {
                        foreach (var item in Main.Albums)
                            a.Items.Add(item);
                        a.ItemCheck += UncheckOtherItems;
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
            var buttonAddImage = new Button()
            {
                Text = "Add Image",
                Top = 25 * i + 75,
                Left = 100,
                ForeColor = Main.BlueColor,
                FlatStyle = FlatStyle.Flat,
                Width = 85,
                Height = 25,
                TabIndex = 1
            };
            buttonAddImage.Click += buttonAddImage_Click;
            label = new Label
            {
                Name = "AddImageLabel",
                Top = 25 * i + 75,
                Left = 200,
                ForeColor = Main.BlueColor,
                Width = 100
            };

            this.Controls.Add(buttonAddImage);
            this.Controls.Add(label);
            if(Entity.GetType() == typeof(Song))
            {
                i++;
                var buttonAddSound = new Button()
                {
                    Text = "Add Sound",
                    Top = 25 * i + 85,
                    Left = 100,
                    ForeColor = Main.BlueColor,
                    FlatStyle = FlatStyle.Flat,
                    Width = 85,
                    Height = 25,
                    TabIndex = 1
                };
                buttonAddSound.Click += buttonAddSound_Click;
                label = new Label
                {
                    Name = "AddSoundLabel",
                    Top = 25 * i + 85,
                    Left = 200,
                    ForeColor = Main.BlueColor,
                    Width = 100
                };

                this.Controls.Add(buttonAddSound);
                this.Controls.Add(label);
            }

            InitializeComponent();
            labelHeading.Text += type.Name;
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
                var control = Controls.Find(propInfo.Name, true).FirstOrDefault();

                if (control == null) continue;
                Type type = propInfo.PropertyType;
                if (type.IsPrimitive || type == typeof(string))
                {
                    propInfo.SetValue(Entity, Convert.ChangeType(control.Text, type));
                }
                else
                {
                    CheckedListBox listBox = (CheckedListBox)control;
                    if (typeof(IEnumerable).IsAssignableFrom(type))
                    {

                        var instance = (IList)Activator.CreateInstance(type);
                        foreach (var item in listBox.CheckedItems)
                        {
                            instance.Add(item);
                        }
                        propInfo.SetValue(Entity, instance);
                    }
                    else
                    {
                        if (listBox.CheckedItems.Count == 0) continue;
                        propInfo.SetValue(Entity, Convert.ChangeType(listBox.CheckedItems[0], type));
                    }
                }
            }
            if (imagePath != null)
            {
                string fileName = (string)Entity.GetType().GetProperty("Name").GetValue(Entity);
                string path = $@"{Main.ResourcesPath}/Images/{fileName}.{imagePath.Split('.').Last()}";
                try { File.Delete(path); } catch { }
                File.Copy(imagePath, path);
            }
            if (soundPath != null)
            {
                string fileName = (string)Entity.GetType().GetProperty("Name").GetValue(Entity);
                string path = $@"{Main.ResourcesPath}/Sounds/{fileName}.{soundPath.Split('.').Last()}";
                try { File.Delete(path); } catch { }
                File.Copy(soundPath, path);
            }          
            
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UncheckOtherItems(object sender, ItemCheckEventArgs e)
        {
            var listBox = sender as CheckedListBox;
            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < listBox.Items.Count; ++ix)
                    if (e.Index != ix) listBox.SetItemChecked(ix, false);
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            };
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;

                ((Label)this.Controls.Find("AddImageLabel", true).FirstOrDefault()).Text = openFileDialog.SafeFileName;
            }
        }
        private void buttonAddSound_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Sound files (*.mp3, *.wav) | *.mp3; *.wav;"
            };
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                soundPath = openFileDialog.FileName;

                ((Label)this.Controls.Find("AddSoundLabel", true).FirstOrDefault()).Text = openFileDialog.SafeFileName;
            }
        }
    }
}
