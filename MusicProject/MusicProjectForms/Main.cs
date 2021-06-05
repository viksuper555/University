using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicProject;
using NAudio.Wave;

namespace MusicProjectForms
{
    public partial class Main : Form
    {
        public static Color BlueColor = Color.FromArgb(10, 146, 234);
        public static Color DarkColor = Color.FromArgb(34, 34, 34);
        public static List<Artist> Artists = new List<Artist>();
        public static List<Album> Albums = new List<Album>();
        public static List<Group> Groups = new List<Group>();
        public static List<Song> Songs = new List<Song>();
        ImageList imageList = new ImageList();
        object selectedObject = null;
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        public Main()
        {
            InitializeComponent();
            #region Design stuff
            imageList.ImageSize = new Size(100, 100);
            dataGridViewDetails.ColumnHeadersDefaultCellStyle.BackColor = DarkColor;
            dataGridViewDetails.ColumnHeadersDefaultCellStyle.ForeColor = BlueColor;
            dataGridViewDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewDetails.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
            dataGridViewDetails.EnableHeadersVisualStyles = false;
            dataGridViewDetails.DefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewDetails.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewDetails.RowTemplate.Height = 80;
            dataGridViewDetails.ForeColor = Color.FromArgb(10, 146, 234);
            #endregion

            this.FormClosing += OnButtonStopClick;

            var paths = Directory.GetFiles(@"C:\Users\viksu\Source\Repos\viksuper555\University\MusicProject\MusicProjectForms\Resources\Images");
            foreach (var path in paths)
            {
                var fileName = Path.GetFileNameWithoutExtension(path);
                imageList.Images.Add(fileName, Image.FromFile(path));
                listViewMain.LargeImageList = imageList;
            }


            var jCole = new Artist() { Name = "J Cole", Age = 40, Nationality = "USA", BirthName = "Jermaine Cole" };
            var kyle = new Artist() { Name = "Kyle", Age = 28, Nationality = "USA", BirthName = "Kyle Harvey" };

            var gorillaz = new Group() { Name = "Gorillaz", Artists = new List<Artist>() { jCole }, };
            var gorillaz2 = new Group() { Name = "Gorillaz", Artists = new List<Artist>() { kyle }, };


            var album = new Album() { Name = "SAD!", Year = 2019, Artists = new List<Artist>() { jCole } };
            var album2 = new Album() { Name = "Demon Days", Year = 2021, Artists = new List<Artist>() { kyle } };

            var song = new Song() { Name = "pesen za dushata", Year = 1990, Genre = "Folk", Artists = new List<Artist>() { jCole }, Album = album };
            var song2 = new Song() { Name = "pesen za dushata2", Year = 1990, Genre = "Folk", Artists = new List<Artist>() { kyle }, Album = album2 };

            album.AddSong(song);
            album2.AddSong(song2);
            jCole.AddAlbum(album);
            kyle.AddAlbum(album2);

            Artists.Add(jCole);
            Artists.Add(kyle);
            Groups.Add(gorillaz);
            Groups.Add(gorillaz2);
            Albums.Add(album);
            Albums.Add(album2);
            var album3 = new Album() { Name = "Demon Days3", Year = 2021, Artists = new List<Artist>() { kyle } };
            var album4 = new Album() { Name = "Demon Days4", Year = 2021, Artists = new List<Artist>() { kyle } };
            var album5 = new Album() { Name = "Demon Days5", Year = 2021, Artists = new List<Artist>() { kyle } };
            Albums.Add(album3);
            Albums.Add(album4);
            Albums.Add(album5);
            var song3 = new Song() { Name = "pesen za dushata3", Year = 1990, Genre = "Folk", Artists = new List<Artist>() { jCole }, Album = album };
            var song4= new Song() { Name = "pesen za dushata4", Year = 1990, Genre = "Folk", Artists = new List<Artist>() { jCole }, Album = album };
            var song5 = new Song() { Name = "pesen za dushata5", Year = 1990, Genre = "Folk", Artists = new List<Artist>() { jCole }, Album = album };

            Songs.Add(song);
            Songs.Add(song2);
            Songs.Add(song3);
            Songs.Add(song4);
            Songs.Add(song5);
            UpdateListViewMain(Artists);
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

        private void buttonArtists_Click(object sender, EventArgs e)
        {
            panelButtonSelection.Top = buttonArtists.Top;
            panelButtonSelection.Height = buttonArtists.Height;
            UpdateListViewMain(Artists);
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            panelButtonSelection.Top = buttonGroups.Top;
            panelButtonSelection.Height = buttonGroups.Height;
            UpdateListViewMain(Groups);
        }

        private void buttonSongs_Click(object sender, EventArgs e)
        {
            panelButtonSelection.Top = buttonSongs.Top;
            panelButtonSelection.Height = buttonSongs.Height;
            UpdateListViewMain(Songs);
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            panelButtonSelection.Top = buttonAlbums.Top;
            panelButtonSelection.Height = buttonAlbums.Height;
            UpdateListViewMain(Albums);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void listViewMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listView = sender as ListView;
            if (listView.SelectedItems.Count == 0)
                return;
            selectedObject = listView.SelectedItems[0].Tag;

            dataGridViewDetails.DataSource = new List<object>() { selectedObject };

            //Ideally we want 200 Column width. If too many columns, we lower that value.
            var columnsWidth = Math.Min(829 / dataGridViewDetails.Columns.Count, 200);
            for (int i = 0; i < dataGridViewDetails.Columns.Count; i++)
            {
                dataGridViewDetails.Columns[i].MinimumWidth = columnsWidth;
            }
            listView.SelectedItems[0].Selected = false;
        }

        private void UpdateListViewMain<T>(T list)
        {
            listViewMain.Items.Clear();
            selectedObject = null;

            panelAudioControls.Visible = ((IEnumerable<object>)list).FirstOrDefault().GetType() == typeof(Song);            

            foreach (var entity in list as IEnumerable<object>)
            {
                listViewMain.Items.Add(new ListViewItem
                {
                    Text = entity.ToString(),
                    Tag = entity,
                    ImageKey = entity.ToString()
                });
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDetails.Rows.Count == 0)
                return;
            if (selectedObject == null)
                return;
            switch (selectedObject.GetType().Name)
            {
                case "Artist":
                    for (int i = Artists.Count - 1; i >= 0; i--)
                    {
                        if (Artists[i].Name == (selectedObject as Artist).Name)
                        {
                            Artists.RemoveAt(i);
                            UpdateListViewMain(Artists);
                            break;
                        }
                    }
                    break;
                case "Song":
                    for (int i = Songs.Count - 1; i >= 0; i--)
                    {
                        if (Songs[i].Name == (selectedObject as Song).Name)
                        {
                            Songs.RemoveAt(i);
                            UpdateListViewMain(Songs);
                            break;
                        }
                    }
                    break;
                case "Album":
                    for (int i = Albums.Count - 1; i >= 0; i--)
                    {
                        if (Albums[i].Name == (selectedObject as Album).Name)
                        {
                            Albums.RemoveAt(i);
                            UpdateListViewMain(Albums);
                            break;
                        }
                    }
                    break;
                case "Group":
                    for (int i = Groups.Count - 1; i >= 0; i--)
                    {
                        if (Groups[i].Name == (selectedObject as Group).Name)
                        {
                            Groups.RemoveAt(i);
                            UpdateListViewMain(Groups);
                            break;
                        }
                    }
                    break;
            }
            selectedObject = null;
            dataGridViewDetails.DataSource = null;

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (selectedObject == null) return;

            var entity = selectedObject;
            var fp = new FormEditEntity(entity);

            fp.ShowDialog();

            if (fp.DialogResult == DialogResult.OK)
            {
                var newEntity = fp.Entity;
                switch (entity.GetType().Name)
                {
                    case "Artist":
                        for (int i = 0; i < Artists.Count; i++)
                        {
                            if (Artists[i].Name == ((Artist)entity).Name)
                                Artists[i] = (Artist)newEntity;
                        }
                        UpdateListViewMain(Artists);
                        break;
                    case "Group":
                        for (int i = 0; i < Groups.Count; i++)
                        {
                            if (Groups[i].Name == ((Group)entity).Name)
                                Groups[i] = (Group)newEntity;
                        }
                        UpdateListViewMain(Groups);
                        break;
                    case "Album":
                        for (int i = 0; i < Albums.Count; i++)
                        {
                            if (Albums[i].Name == ((Album)entity).Name)
                                Albums[i] = (Album)newEntity;
                        }
                        UpdateListViewMain(Albums);
                        break;
                    case "Song":
                        for (int i = 0; i < Songs.Count; i++)
                        {
                            if (Songs[i].Name == ((Song)entity).Name)
                                Songs[i] = (Song)newEntity;
                        }
                        UpdateListViewMain(Songs);
                        break;
                }

            }
            selectedObject = null;
            dataGridViewDetails.DataSource = null;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var fp = new FormAddEntity(listViewMain.Items[0]?.Tag.GetType().FullName);

            fp.ShowDialog();

            if (fp.DialogResult == DialogResult.OK)
            {
                var entity = fp.Entity;
                switch (entity.GetType().Name)
                {
                    case "Artist":
                        Artists.Add((Artist)entity);
                        UpdateListViewMain(Artists);
                        break;
                    case "Group":
                        Groups.Add((Group)entity);
                        UpdateListViewMain(Groups);
                        break;
                    case "Album":
                        Albums.Add((Album)entity);
                        UpdateListViewMain(Albums);
                        break;
                    case "Song":
                        Songs.Add((Song)entity);
                        UpdateListViewMain(Songs);
                        break;
                }

            }
            Validate();
        }

        private void OnButtonPlayClick(object sender, EventArgs e)
        {
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            if (audioFile == null)
            {
                audioFile = new AudioFileReader(@"C:\Users\viksu\Source\Repos\viksuper555\University\MusicProject\MusicProjectForms\Resources\Sounds\SAD!.mp3");
                outputDevice.Init(audioFile);
            }
            outputDevice.Play();
        }
        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
        }

        private void OnButtonStopClick(object sender, EventArgs e)
        {
            outputDevice?.Stop();
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            if (audioFile != null)
                audioFile.CurrentTime = audioFile.CurrentTime.Add(TimeSpan.FromSeconds(10));
        }
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (audioFile != null)
                audioFile.CurrentTime = audioFile.CurrentTime.Subtract(TimeSpan.FromSeconds(10));
        }
        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            if (audioFile != null)
                audioFile.Volume = trackBarVolume.Value / 100f;
        }
    }
}
