using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public class Artist : Song
    {
        public string Genre { get; set; }

        public Artist(string artist, string title, int lengthInSeconds, string genre) : base(artist, title, lengthInSeconds)
        {
            Genre = genre;
        }

        public override string ToString()
        {
            return base.ToString() + "\nGenre: " + Genre; 
        }


    }
}
