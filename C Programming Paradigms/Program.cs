using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programming_Paradigms
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> cities = new[] { "Cornelius", "Hillsboro", "Forest Grove", "Gaston" };
            IEnumerable<string> query = cities.Filter(StringsThatStartWithL);            
            
            foreach (var city in query){

                Console.WriteLine(city);

            }
        }

        static bool StringsThatStartWithL(string s)
        {
            return s.StartsWithL("L");
        }
    }

    public static class FilterExtensions
    {
        public static IEnumerable<string> Filter(this IEnumerable<string> input, FilterDelegate<string> predicate)
        {
            foreach (var item in input)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }

        }

        public delegate bool FilterDelegate<T>(T item);
    }
   
}
