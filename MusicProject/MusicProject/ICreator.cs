using System;
using System.Collections.Generic;
using System.Text;

namespace MusicProject
{
    public interface ICreator
    {
        public List<Album> GetAlbums();
        public List<Song> GetSingles();
        public Album GetAlbum(string name);
        public Song GetSong(string name);
        public void AddAlbum(Album album);
        public void DeleteAlbum(string name);
        public void UpdateAlbum(Album album);
    }
}
