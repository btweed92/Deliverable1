using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double a,b,c,d;
            
            
            

            Console.WriteLine("Welcome, please enter your first currency amount here:");
            input = Console.ReadLine();
            a = Convert.ToDouble(input);

            b = Convert.ToDouble(input);
            Console.WriteLine("Thank you, now please enter your second currency amount here:");
            Console.ReadLine();
            

            Console.WriteLine("Thanks again (last one, now please enter your third currency amount here:");
            input = Console.ReadLine();
            c = Convert.ToDouble(input);

            Console.WriteLine("The total amount of your currencies is: " + (a + b + c));

            d = (a + b + c);
            

            Console.WriteLine("The average amount of your currencies is: " + Math.Round(d / 3) );

            

            double[] input2 = { a, b, c };

            double lowest = input2.Min();
            double highest = input2.Max();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CreateSpecificCulture("da-DK");


            Console.WriteLine("The smallest currency amount you have entered is: " + lowest);
            Console.WriteLine("The highest currency amount you have entered is: " + highest);

            Console.WriteLine("The total amount of currency you have entered in USD (United States Dollar) is: $" + d.ToString("n2"));
            d = Convert.ToInt32(d);
            Console.WriteLine("The total amount of currency you have entered in SEK (Swedish Krona) is: " + d.ToString("C3",
                  CultureInfo.CreateSpecificCulture("da-DK")));
            d = Convert.ToInt32(d);
            Console.WriteLine("The total amount of currency you have entered in YEN (Japanese Yen) is: ¥" + d);
            Console.WriteLine("The total amount of currency you have entered in THB (Thai Baht) is: ฿" + d.ToString("n2"));
                


            Console.ReadLine();
            
        }
    }
}
