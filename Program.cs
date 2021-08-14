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
                Console.WriteLine("Greetings user, Welcome to my Clock");
                Console.WriteLine($"Normal Time> {datetimenow.Hour}:{datetimenow.Minute}:{datetimenow.Second} Date> {datetimenow.Day}.{datetimenow.Month}.{datetimenow.Year}");
                Console.WriteLine($"Bineary Time> {binstring(datetimenow.Hour)}:{binstring(datetimenow.Minute)}:{binstring(datetimenow.Second)} Date> {binstring(datetimenow.Day)}.{binstring(datetimenow.Month)}.{binstring(datetimenow.Year)}");
                Console.WriteLine($"Hexidecimal Time> {hexstring(datetimenow.Hour)}:{hexstring(datetimenow.Minute)}:{hexstring(datetimenow.Second)} Date> {hexstring(datetimenow.Day)}.{hexstring(datetimenow.Month)}.{hexstring(datetimenow.Year)}");
                Console.WriteLine($"Octal Time> {octstring(datetimenow.Hour)}:{octstring(datetimenow.Minute)}:{octstring(datetimenow.Second)} Date> {octstring(datetimenow.Day)}.{octstring(datetimenow.Month)}.{octstring(datetimenow.Year)}");
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
