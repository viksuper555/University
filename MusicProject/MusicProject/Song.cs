using System;
using System.Collections.Generic;
using System.Text;

namespace MusicProject
{
    public class Song
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public Album Album { get; set; }

        public List<Artist> Artists { get; set; } = new List<Artist>();

        public string Genre { get; set; }

        private Popularity popularity;

        public string GetCreators()
        {
            return string.Join(", ", this.Artists);
        }

        public Album GetAlbum()
        {
            return this.Album;
        }
   
        public string GetPopularity()
        {
            return popularity.ToString();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
