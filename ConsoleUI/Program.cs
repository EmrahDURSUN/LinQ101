using LinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ListManager.LoadSampleData();

            // .OrderBy returns a IEnumerable, That want us to write back To people List
            // now we are overwriting our people list with ordered list we can also write it to new list
            // here is  x represent a person, you are ordering them by their surname and writing down to list

            //            people = people.OrderBy(x => x.LastName).ThenByDescending(x => x.YearsExperience ).ToList();  //First we order the Last name then we took them and descend by years of experience


            //            people = people.OrderByDescending(x => x.LastName).ThenBy(x => x.YearsExperience).ToList();   // repeating descending ThenBy it does the same thing as before order or descend

            //            people = people.Where(x => x.YearsExperience > 5 && x.Birthday.Month == 8).ToList();           // If person x has more experience then 5 years and born month 8, add him to list


            //foreach (var person in people)
            //{
            //    Console.WriteLine($"{person.FirstName} {person.LastName} ( {person.Birthday.ToShortDateString() } ) : Experience {person.YearsExperience}");
            //}

            int yearsSum = 0;

            int yearsTotal = people.Sum(x => x.YearsExperience); // Take each persons experience in people list. And sum up them
            Console.WriteLine($"Total experience is =  {yearsTotal}");  // output =  94

            yearsSum = people.Where(x => x.Birthday.Month == 8).Sum(x => x.YearsExperience);
            Console.WriteLine($" People who boen 8th monat has total experience =  {yearsSum}");

            Console.ReadLine();
        }
    }
}
