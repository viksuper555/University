using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MusicProject
{
    [Serializable]
    [DataContract(IsReference = true)]
    public abstract class Creator
    {
        private string name;
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        public List<Album> Albums { get; set; } = new List<Album>();
        [DataMember]
        public List<Song> Singles { get; set; } = new List<Song>();

        public virtual string GetStatus()
        {
            return Singles.Count > 1 ? "Active" : "Just banded together"; 
        }
    }
}
