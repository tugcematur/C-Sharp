using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŞampiyonlarLigi
{
    class Takim
    {
        private string teamName;
        private string teamCountry;

   


        public Takim(string name, string country)
        {
            teamName = name;
            teamCountry = country;
        }

        public string TeamName
        {
            get
            {
                return  teamName;
            }
            set
            {
                teamName = value;
            }
        }


        public string Country
        {
            get
            {
                return teamCountry;
            }

            set
            {
                teamCountry = value;
            }
        }


        public  override string ToString ()
        {
            return teamName + "-" + teamCountry;
        }
    }
}
