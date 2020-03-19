using System;
using System.ComponentModel;

namespace CinemaSystemProjectB
{
    
    [DefaultProperty("Name")]
    public class MovieInfo
    {
        [Category("ID"), Description("Name of movie")]
        public string Title { get; set; }
        [Category("ID"), Description("Movie synopsis")]
        public string Synopsis { get; set; }

    }
}
