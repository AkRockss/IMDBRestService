using System.ComponentModel.DataAnnotations;

namespace IMDBRestService.Models
{
    public class TitlePrincipals
    {
        [Key]
        public int tconst { get; set; }
        public int ordering { get; set; }
        public int nconst { get; set; }
        public string catergory { get; set; }
        public string job { get; set; }
        public string characters { get; set; }
    }
}
