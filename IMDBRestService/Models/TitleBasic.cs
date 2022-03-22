using System.ComponentModel.DataAnnotations;


namespace IMDBRestService.Models
{
    public class TitleBasic
    {
        [Key]
        public int tconst { get; set; }
        public string titleType { get; set; }
        public string primaryTitle { get; set; }
        public string originalTitle { get; set; }
        public bool isAdult { get; set; }
        public int startYear { get; set; }
        public int endYear { get; set; }
        public int runTimeMinutes { get; set; }
        public string genre { get; set; }

    }
}
