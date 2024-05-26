
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace oop3.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int YearId { get; set; }
        [ForeignKey(nameof(YearId))]
        public Year? Year { get; set; }
        public int GenreId { get; set; }
        [ForeignKey(nameof(GenreId))]
        public Genre? Genre { get; set; }
    }
}



