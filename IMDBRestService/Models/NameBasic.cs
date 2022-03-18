using System;


namespace IMDBRestService.Models
{
    public class NameBasic
    {
        
        public string nconst { get; set; }
        public string primaryName { get; set; }
        public string birthYear { get; set; }
        public string deathYear { get; set; }
        public string primaryProfession { get; set; }
        public string knownForTitles { get; set; }

        public int? birthYearNull
        {
            get
            {
                if (birthYear.ToLower() == "\\n")
                {
                    return null;
                }
                return int.Parse(birthYear);
            }
        }
        public int? deathYearNull
        {
            get
            {
                if (deathYear.ToLower() == "\\n")
                {
                    return null;
                }
                try
                {
                    return int.Parse(deathYear);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("deathYear is: " + deathYear);
                    throw ex;
                }
            }
        }
    }
}
