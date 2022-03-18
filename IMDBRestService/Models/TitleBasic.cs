using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMDBRestService.Models
{
    public class TitleBasic
    {
        public string tconst { get; set; }
        public string titleType { get; set; }
        public string primaryTitle { get; set; }
        public string originalTitle { get; set; }
        public string isAdult { get; set; }
        public string startYear { get; set; }
        public string endYear { get; set; }
        public string runTimeMinutes { get; set; }

        public string genre { get; set; }

        public bool? isAdultNull
        {
            get
            {
                if (isAdult.ToLower() == "\\n")
                {
                    return null;
                }
                return isAdult == "1";
            }
        }
        public int? startYearNull
        {
            get
            {
                if (startYear.ToLower() == "\\n")
                {
                    return null;
                }
                return int.Parse(startYear);
            }
        }
        public int? endYearNull
        {
            get
            {
                if (endYear.ToLower() == "\\n")
                {
                    return null;
                }
                try
                {
                    return int.Parse(endYear);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("endyear is: " + endYear);
                    throw ex;
                }
            }
        }
        public int? runTimeMinutesNull
        {
            get
            {
                if (runTimeMinutes.ToLower() == "\\n")
                {
                    return null;
                }
                return int.Parse(runTimeMinutes);
            }
        }
    }
}
