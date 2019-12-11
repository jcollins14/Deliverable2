using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string message = "";
            int checksum = "";
            string scan = "";
            int convert = 0;

            Console.WriteLine("Please input a message to be encoded.");
            input = Console.ReadLine();
            input.ToUpper();

            while (input != "")
            {
                scan = input.Substring(0, 1);
                input.Remove(0, 1);
                /* Get Unicode value from Scan and put into convert */
                checksum += convert;
                message += (convert - 64) + "- "; 
            }

            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Your checksum is " + checksum);

        }
    }
}
