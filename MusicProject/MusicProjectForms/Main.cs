using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicProject;

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

        public Main()
        {
            InitializeComponent();
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

            //for (int i = 0; i < dataGridViewDetails.Rows[0].Cells.Count; i++)
            //{
            //    dataGridViewDetails.Rows[0].Cells[i].Style.BackColor = Color.FromArgb(34, 34, 34);
            //}


            dataGridViewDetails.ForeColor = Color.FromArgb(10, 146, 234);


            var paths = Directory.GetFiles(@"C:\Users\viksu\Desktop\MusicProjectForms\Resources\Images");
            foreach(var path in paths)
            {
                var fileName = Path.GetFileNameWithoutExtension(path);
                imageList.Images.Add(fileName, Image.FromFile(path));
                listViewMain.LargeImageList = imageList;
            }


            var ivan = new Artist() { Name = "J Cole", Age = 40, Nationality = "Bulgarian", BirthName = "Ivan Petrovich" };
            var ivan2 = new Artist() { Name = "Vankata2", Age = 15, Nationality = "Bulgarian", BirthName = "Ivan Petrovich" };

            var gorillaz = new Group() { Name = "Gorillaz", Artists = new List<Artist>() { ivan }, };
            var gorillaz2 = new Group() { Name = "Gorillaz", Artists = new List<Artist>() { ivan2 }, };


            var album = new Album() { Name = "album1", Year = 2021, Artists = new List<Artist>() { ivan } };
            var album2 = new Album() { Name = "Demon Days", Year = 2021, Artists = new List<Artist>() { ivan2 } };

            var song = new Song() { Name = "pesen za dushata", Year = 1990, Genre = "Folk", Artists = new List<Artist>() { ivan }, Album = album };
            var song2 = new Song() { Name = "pesen za dushata2", Year = 1990, Genre = "Folk", Artists = new List<Artist>() { ivan2 }, Album = album2 };

            album.AddSong(song);
            album2.AddSong(song2);
            ivan.AddAlbum(album);
            ivan2.AddAlbum(album2);

            artists.Add(ivan);
            artists.Add(ivan2);
            artists.Add(ivan2);
            artists.Add(ivan2);
            artists.Add(ivan2);
            artists.Add(ivan2); artists.Add(ivan2);
            artists.Add(ivan2);
            artists.Add(ivan2);
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
            if (listView.SelectedItems.Count <= 0)
                return;
            var item = listView.SelectedItems[0].Tag;
            //var a = song.GetType().Name;
            
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
                    for (int i = artists.Count-1; i >= 0; i--)
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

        }

        private void Add_Click(object sender, EventArgs e)
        {
            var fp = new FormAddEntity(listViewMain.Items[0]?.Tag.GetType().FullName);

            fp.ShowDialog();
        }
    }
}
