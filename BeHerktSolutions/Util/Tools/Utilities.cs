using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BeHerktSolutions.Util
{
    class Utilities
    {

        public static string GetDayInSpanish()
        {
            CultureInfo culture = new System.Globalization.CultureInfo("es-ES");
            return culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek).ToUpper();
        }

        public static string GetMonthInSpanish()
        {
            CultureInfo culture = new System.Globalization.CultureInfo("es-ES");
            return culture.DateTimeFormat.GetMonthName(DateTime.Today.Month).ToUpper();
        }

        public static string GetConnectionString()
        {
            ConnectionStringSettings settings = System.Configuration.ConfigurationManager.ConnectionStrings["BEHERKSOLUTIONS"];
            if (settings == null)
            {
                throw new Exception("Database connection settings have not been set in App.config file");
            }
                
            return settings.ConnectionString;
        }

    }
}
