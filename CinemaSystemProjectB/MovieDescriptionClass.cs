using System;
using System.ComponentModel;

namespace CinemaSystemProjectB
{
    
    [DefaultProperty("Name")]
    public class MovieDescriptionClass
    {
        public string MovieTitle { get; set; }
        public string Release { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public string Prize { get; set; }
        public string Trailer { get; set; }
        public string Synopsis { get; set; }

    }
}
