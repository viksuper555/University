﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MusicProject
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class Artist : Creator, ICreator
    {
        [DataMember]
        public string BirthName { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public string Nationality { get; set; }

        private int? YearOfDeath { get; set; }

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
            //I know it's unnecessary
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
                {
                    Albums[i] = album;
                    break;
                }
            }
        }

        public override string GetStatus()
        {
            if (YearOfDeath == null)
                return "Alive";
            else
                return "Inactive since " + YearOfDeath;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
