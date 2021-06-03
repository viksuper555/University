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
        List<Artist> artists = new List<Artist>();
        List<Album> albums = new List<Album>();
        List<Group> groups = new List<Group>();
        List<Song> songs = new List<Song>();
        ImageList imageList = new ImageList();
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

            var paths = Directory.GetFiles(@"C:\Users\Viktor\source\repos\viksuper555\University\MusicProject\MusicProjectForms\Resources\Images");
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

            artists.Add(jCole);
            artists.Add(kyle);
            artists.Add(kyle);
            artists.Add(kyle);
            artists.Add(kyle);
            artists.Add(kyle);
            artists.Add(kyle);
            artists.Add(kyle);
            artists.Add(kyle);
            groups.Add(gorillaz);
            groups.Add(gorillaz2);
            albums.Add(album);
            albums.Add(album2);
            songs.Add(song);
            songs.Add(song2);
            UpdateListViewMain(artists);
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
            UpdateListViewMain(artists);
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            panelButtonSelection.Top = buttonGroups.Top;
            panelButtonSelection.Height = buttonGroups.Height;
            UpdateListViewMain(groups);
        }

        private void buttonSongs_Click(object sender, EventArgs e)
        {
            panelButtonSelection.Top = buttonSongs.Top;
            panelButtonSelection.Height = buttonSongs.Height;
            UpdateListViewMain(songs);
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            panelButtonSelection.Top = buttonAlbums.Top;
            panelButtonSelection.Height = buttonAlbums.Height;
            UpdateListViewMain(albums);
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
            var item = listView.SelectedItems[0].Tag;

            dataGridViewDetails.DataSource = new List<object>() { item };

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
            var a = dataGridViewDetails.Rows[0]?.DataBoundItem;
            if (a == null)
                return;
            switch (a.GetType().Name)
            {
                case "Artist":
                    for (int i = artists.Count - 1; i >= 0; i--)
                    {
                        if (artists[i].Name == (a as Artist).Name)
                        {
                            artists.RemoveAt(i);
                            UpdateListViewMain(artists);
                            break;
                        }
                    }
                    break;
                case "Song":
                    for (int i = songs.Count - 1; i >= 0; i--)
                    {
                        if (songs[i].Name == (a as Song).Name)
                        {
                            songs.RemoveAt(i);
                            UpdateListViewMain(songs);
                            break;
                        }
                    }
                    break;
                case "Album":
                    for (int i = albums.Count - 1; i >= 0; i--)
                    {
                        if (albums[i].Name == (a as Album).Name)
                        {
                            albums.RemoveAt(i);
                            UpdateListViewMain(albums);
                            break;
                        }
                    }
                    break;
                case "Group":
                    for (int i = groups.Count - 1; i >= 0; i--)
                    {
                        if (groups[i].Name == (a as Group).Name)
                        {
                            groups.RemoveAt(i);
                            UpdateListViewMain(groups);
                            break;
                        }
                    }
                    break;
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewMain.SelectedItems.Count == 0) return;
            var entity = listViewMain.SelectedItems[0].Tag;
            var fp = new FormEditEntity(entity);

            fp.ShowDialog();

            if (fp.DialogResult == DialogResult.OK)
            {
                var newEntity = fp.Entity;
                switch (entity.GetType().Name)
                {
                    case "Artist":
                        for (int i = 0; i < artists.Count; i++)
                        {
                            if (artists[i].Name == ((Artist)entity).Name)
                                artists[i] = (Artist)newEntity;
                        }
                        UpdateListViewMain(artists);
                        break;
                    case "Group":
                        for (int i = 0; i < groups.Count; i++)
                        {
                            if (groups[i].Name == ((Group)entity).Name)
                                groups[i] = (Group)newEntity;
                        }
                        UpdateListViewMain(groups);
                        break;
                    case "Album":
                        for (int i = 0; i < albums.Count; i++)
                        {
                            if (albums[i].Name == ((Album)entity).Name)
                                albums[i] = (Album)newEntity;
                        }
                        UpdateListViewMain(albums);
                        break;
                    case "Song":
                        for (int i = 0; i < songs.Count; i++)
                        {
                            if (songs[i].Name == ((Song)entity).Name)
                                songs[i] = (Song)newEntity;
                        }
                        UpdateListViewMain(songs);
                        break;
                }

            }
            Validate();
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
                        artists.Add((Artist)entity);
                        UpdateListViewMain(artists);
                        break;
                    case "Group":
                        groups.Add((Group)entity);
                        UpdateListViewMain(groups);
                        break;
                    case "Album":
                        albums.Add((Album)entity);
                        UpdateListViewMain(albums);
                        break;
                    case "Song":
                        songs.Add((Song)entity);
                        UpdateListViewMain(songs);
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
                audioFile = new AudioFileReader(@"C:\Users\Viktor\source\repos\viksuper555\University\MusicProject\MusicProjectForms\Resources\Sounds\SAD!.mp3");
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
