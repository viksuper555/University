using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicProject
{
    public class Group : Creator, ICreator
    {
        public List<Artist> Artists { get; set; } = new List<Artist>();
    
        private bool Active { get; set; }

        public void AddAlbum(Album album)
        {
            this.Albums.Add(album);
            this.Singles.AddRange(album.GetSongs());
        }

        public void DeleteAlbum(string name)
        {
            var album = this.Albums.FirstOrDefault(x => x.Name == name);
            this.Albums.Remove(album);
        }

        public Album GetAlbum(string name) => this.Albums.FirstOrDefault(x => x.Name == name);

        public List<Album> GetAlbums()
        {
            var albums = from a in this.Albums
                         select a;

            return albums.ToList();
        }
        public List<Song> GetSingles() => this.Singles;

        public Song GetSong(string name) => this.Singles.FirstOrDefault(x => x.Name == name);

        public void UpdateAlbum(Album album)
        {
            for (int i = 0; i < Albums.Count; i++)
            {
                if (Albums[i].Name == album.Name)
                    Albums[i] = album;
            }
        }

        public override string GetStatus()
        {
            return Active ? "Active" : "Inactive";
        }

        public override string ToString()
        {
            return this.Name;
        }

    }
}
