using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string message = "";
            int checksum = 0;

            Console.WriteLine("Please input a message to be encoded.");
            input = Console.ReadLine();
            input = input.ToUpper();

            foreach (char a in input)
            {
                int encode = a;
                checksum += encode;
                encode -= 64;
                message += (encode.ToString()) + "-";
            }

            int length = message.Length;
            length -= 1;
            message = message.Remove(length, 1);

            Console.WriteLine("Your encoded message is: " + message);
            Console.WriteLine("Your checksum is: " + checksum);
        }
    }
}
