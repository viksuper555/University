using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MusicProject
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class Song
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
        public Album Album { get; set; }
        [DataMember]
        public List<Artist> Artists { get; set; } = new List<Artist>();
        [DataMember]
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
