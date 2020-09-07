using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Song
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int LengthInSeconds { get; set; }

        public Song(string artist, string title, int lengthInSeconds)
        {
            Artist = artist;
            Title = title;
            LengthInSeconds = lengthInSeconds;
        }

        public Song () { }
        public override string ToString()
        {
            return string.Format("\nArtist: {0}\nTitle: {1}\nLenght in seconds: {2}",
                Artist,
                Title,
                LengthInSeconds);

        }
    }
}
