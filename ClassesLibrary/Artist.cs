using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Artist
    {
        //fields - N/A

        //props
        public List<Song> Tracks { get; set; }
        public string Title { get; set; }
        public Enum Genre { get; set; }

        //ctors
        public Artist(List<Song> tracks, string title, Enum genre)
        {
            Tracks = tracks;
            Title = title;
            Genre = genre;
        }

        public Artist()
        {

        }

        //methods
        public override string ToString()
        {
            string songsNeeded = "";
            foreach (Song song in Tracks)
            {
                songsNeeded += song.Title + "\n";
            }//end foreach
            return string.Format("Songs: \n{0}\n" +
                "Title: {1}\n" +
                "Genre: {2}\n", songsNeeded, Title, Genre);
        }//end ToString

    }//end class
}//end namespace
