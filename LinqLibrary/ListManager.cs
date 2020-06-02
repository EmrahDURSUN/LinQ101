using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
    public class ListManager
    {
        public static List<Person> LoadSampleData()
        {
            List<Person> output = new List<Person>();

            output.Add(new Person { FirstName = " Emrah", LastName = " Durusu ", Birthday = Convert.ToDateTime("16/08/1969"), YearsExperience = Convert.ToInt32("8") });
            output.Add(new Person { FirstName = " Savas", LastName = " Dursun ", Birthday = Convert.ToDateTime("16/08/1555"), YearsExperience = Convert.ToInt32("5") });
            output.Add(new Person { FirstName = " Emira", LastName = " Ursula ", Birthday = Convert.ToDateTime("16/08/1999"), YearsExperience = Convert.ToInt32("9") });
            output.Add(new Person { FirstName = " Demir", LastName = " Domanl ", Birthday = Convert.ToDateTime("16/08/2003"), YearsExperience = Convert.ToInt32("3") });
            output.Add(new Person { FirstName = " Amira", LastName = " Durabl ", Birthday = Convert.ToDateTime("16/08/1209"), YearsExperience = Convert.ToInt32("19") });

            return output;
        }
    }
}
