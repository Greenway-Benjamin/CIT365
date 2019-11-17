using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Genre
    {
        public Genres MovieGenre { get; set; }
    }

    public enum Genres
    {
        Action,
        Drama,
        Faith,
        Comedy
    }
}
