using System.ComponentModel.DataAnnotations;

namespace IMDBRestService.Models
{
    public class TitleCrew
    {
        [Key]
        public int tconst { get; set; }
        public string directors { get; set; }
        public string writers { get; set; }
    }
}
