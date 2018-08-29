using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAEnumDrill
{
    class Program
    {
        public enum days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What day of the week is today?");
                string userInput = Console.ReadLine();
                days today = (days)Enum.Parse(typeof(days), userInput); 
                Console.WriteLine(today);
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
    }
}
