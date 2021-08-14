using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            while (true) {
                Console.SetCursorPosition(0, 0);
                var datetimenow = System.DateTime.Now;
                Console.WriteLine("Greetings user,");
                Console.WriteLine($"The time is {datetimenow.Hour}:{datetimenow.Minute}:{datetimenow.Second} On {datetimenow.Day}.{datetimenow.Month}.{datetimenow.Year}");
                Console.WriteLine($"The time is {binstring(datetimenow.Hour)}:{binstring(datetimenow.Minute)}:{binstring(datetimenow.Second)} On {binstring(datetimenow.Day)}.{binstring(datetimenow.Month)}.{binstring(datetimenow.Year)}");
                Console.WriteLine($"The time is {hexstring(datetimenow.Hour)}:{hexstring(datetimenow.Minute)}:{hexstring(datetimenow.Second)} On {hexstring(datetimenow.Day)}.{hexstring(datetimenow.Month)}.{hexstring(datetimenow.Year)}");
                Console.WriteLine($"The time is {octstring(datetimenow.Hour)}:{octstring(datetimenow.Minute)}:{octstring(datetimenow.Second)} On {octstring(datetimenow.Day)}.{octstring(datetimenow.Month)}.{octstring(datetimenow.Year)}");
            }
        }

        static string binstring(int input)
        {
            var output = Convert.ToString(input, 2);
            return output;
        }

        static string hexstring(int input)
        {
            var output = Convert.ToString(input, 16);
            return output;
        }

        static string octstring(int input)
        {
            var output = Convert.ToString(input, 8);
            return output;
        }
    }
}
