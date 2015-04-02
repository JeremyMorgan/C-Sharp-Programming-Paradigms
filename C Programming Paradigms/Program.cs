using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace C_Programming_Paradigms
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> cities = new[] { "Cornelius", "Hillsboro", "Forest Grove", "Gaston" };
            IEnumerable<string> query = cities.StringsThatStartWith("F");

            
            
            foreach (var city in query){

                Console.WriteLine(city);

            }

            Console.ReadLine();
        }
    }

    public static class FilterExtensions
    {
        public static IEnumerable<string> StringsThatStartWith(this IEnumerable<string> input, string start)
        {
            foreach (var s in input)
            {
                if (s.StartsWith(start))
                {
                    yield return s;
                }
            }

        }
    }
   
}
