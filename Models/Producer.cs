using System.ComponentModel.DataAnnotations.Schema;

namespace oop3.Models
{
    public class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FilmId { get; set; }
        [ForeignKey("FilmId")]
        public Film? Film { get; set; }


    }
}
