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
            Clockutils clockutil = new Clockutils();
            Console.Clear();
            Console.CursorVisible = false;
            while (true) {
                clockutil.updatedatetime();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Greetings user, Welcome to my Clock");
                Console.WriteLine("## Normal (Base 10) ##");
                Console.WriteLine($"Time> " + clockutil.Dectime());
                Console.WriteLine($"Date> " + clockutil.Decdate());
                Console.WriteLine("## Bineary (Base 2) ##");
                Console.WriteLine($"Time> " + clockutil.Bintime());
                Console.WriteLine($"Date> " + clockutil.Bindate());
                Console.WriteLine("## Octal (Base 8) ##");
                Console.WriteLine($"Time> " + clockutil.Octtime());
                Console.WriteLine($"Date> " + clockutil.Octdate());
                Console.WriteLine("## Hexidecimal (Base 16) ##");
                Console.WriteLine($"Time> " + clockutil.Hextime());
                Console.WriteLine($"Date> " + clockutil.Hexdate());
                
            }
        }
        static string binstring(int input, int minlength)
        {
            var output = Convert.ToString(input, 2);
            
            if (output.Length < minlength)
            {
                for(int i = output.Length; i < minlength; i++)
                {
                    output = "0" + output;
                }
            }
            
            var count = 0;
            var spacer = "";
            for (int i = 0; i < output.Length; i++)
            {
                if (count == 4)
                {
                    count = 0;
                    spacer = spacer + " " + output[i];
                }
                else
                {
                    spacer = spacer + output[i];
                    count = count + 1;
                }
                
            }

            output = spacer;
            return output;
        }
    }
}
