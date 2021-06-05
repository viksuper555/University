using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MusicProject
{ 
    [DataContract(IsReference = true)]
    public class Album
    {
        private string name;
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int year;

        [DataMember]
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        [DataMember]
        public List<Song> Songs { get; set; } = new List<Song>();

        [DataMember]
        public List<Artist> Artists { get; set; } = new List<Artist>();

        private Popularity popularity;
   
        public List<Song> GetSongs()
        {
            return Songs;
        }

        public string GetCreators()
        {
            return string.Join(", ", this.Artists);
        }
    
        public Song GetSong(string name)
        {
            return this.Songs.FirstOrDefault(x => x.Name == name);
        }

        public string GetPopularity()
        {
            return popularity.ToString();
        }

        public List<string> GetSongGenres()
        {
            return Songs.Select(x => x.Genre).Distinct().ToList();
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void DeleteSong(Song song)
        {
            var oldSong = Songs.FirstOrDefault(x => x.Name == song.Name);
            Songs.Remove(oldSong);
        }

        public void UpdateSong(Song song)
        {
            for (int i = 0; i < Songs.Count; i++)
            {
                if(Songs[i].Name == song.Name)
                {
                    Songs[i] = song;
                    break;
                }    
            }
        }
        public override string ToString()
        {
            return this.Name;
        }
    }

    public enum Popularity
    {
        Dead,
        Frozen,
        Chilly,
        Cold,
        Cool,
        Warm,
        HOT
    }
}
