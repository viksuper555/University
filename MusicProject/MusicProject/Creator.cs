using System;
using System.Collections.Generic;
using System.Text;

namespace MusicProject
{
    public abstract class Creator
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Album> Albums { get; set; } = new List<Album>();

        public List<Song> Singles { get; set; } = new List<Song>();

        public virtual string GetStatus()
        {
            return Singles.Count > 1 ? "Active" : "Just banded together"; 
        }
    }
}
