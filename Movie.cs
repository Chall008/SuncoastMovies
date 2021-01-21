using System.Collections.Generic;

namespace SuncoastMovies
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PrimaryDirector { get; set; }
        public int YearReleased { get; set; }
        public string Genre { get; set; }

        //this is the column that stores the foreign key ID (RatingId)
        public int RatingId { get; set; }
        // Teach Movie model (class) that is related to the Rating model (class)
        //
        //      Rating Class
        //      |
        //      |     class property
        //      |       |
        public Rating Rating { get; set; }


        //  movie HAS MANY Role
        public List<Role> Roles { get; set; }





    }




}
