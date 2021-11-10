using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID19TheGame.Common
{
    public static class Driver
    {
       public static string ConfiguredCovidGameURL
        {
            get
            {
                string covidGameURL = ConfigurationManager.AppSettings["CovidGameURL"];
                return covidGameURL;
            }
        }
    }
}
