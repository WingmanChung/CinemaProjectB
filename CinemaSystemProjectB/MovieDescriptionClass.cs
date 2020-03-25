using System;
using System.ComponentModel;

namespace CinemaSystemProjectB
{
    
    [DefaultProperty("Name")]
    public class MovieDescriptionClass
    {
        public string Titel { get; set; }
        public string Release { get; set; }
        public string Regisseur { get; set; }
        public string Genre { get; set; }
        public string Taal { get; set; }
        public string Prijs { get; set; }
        public string Trailer { get; set; }
        public string Synopsis { get; set; }

    }
}
