using LinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
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
            people = people.OrderBy(x => x.LastName).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} ( {person.Birthday.ToShortDateString() } ) : Experience {person.YearsExperience}");
            }
            Console.ReadLine();
        }
    }
}
