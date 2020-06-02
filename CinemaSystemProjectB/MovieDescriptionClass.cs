using System;

namespace CinemaSystemProjectB
{
    
   
    public class MovieDescriptionClass
    {
        public string Title { get; set; }
        public string Release { get; set; }
        public string Age { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public float Rating { get; set; }
        public string Price { get; set; }
        public string Runtime { get; set; }
        public string FilmTechnology { get; set; }
        public string Trailer { get; set; }
        public string Synopsis { get; set; }
        public string Image { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is MovieDescriptionClass movieDescription)
			{
                return this.Title == movieDescription.Title &&
                    this.Release == movieDescription.Release && 
                    this.Language == movieDescription.Language;
            }
            return base.Equals(obj);
        }
    }
}
