using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Programming_Paradigms.Extensions;
namespace C_Programming_Paradigms
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> cities = new[] { "Cornelius", "Hillsboro", "Forest Grove", "Gaston" };
            IEnumerable<string> query = cities.Filter(delegate(string item)
            {
                return item.StartsWith("L");
            });
            
            foreach (var city in query){

                Console.WriteLine(city);

            }
        }

        static bool StringsThatStartWithL(string s)
        {
            return s.StartsWithL("L");
        }
    }
 
namespace Extensions
{
    public static class FilterExtensions
    {
        public static IEnumerable<T> Filter(this IEnumerable<T> input, FilterDelegate<T> predicate)
        {
            foreach (var item in input)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }

        }      
    }

    public delegate bool FilterDelegate<T>(T item);
   
    }
}
