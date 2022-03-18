
namespace IMDBRestService.Models
{
    public class TitleAkas
    {
        public string titleId { get; set; }
        public string ordering { get; set; }
        public string title { get; set; }
        public string region { get; set; }
        public string language { get; set; }
        public string types { get; set; }
        public string attributes { get; set; }
        public string isOriginalTitle { get; set; }


        public bool? isOriginalTitleNull
        {
            get
            {
                if (isOriginalTitle.ToLower() == "\\n")
                {
                    return null;
                }
                return isOriginalTitle == "1";
            }
        }
    }
}
