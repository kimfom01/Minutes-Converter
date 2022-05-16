using System;

namespace Minutes_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            int time, mins, hours;

            Console.Write("Enter the time in minutes: ");
            time = Int32.Parse(Console.ReadLine());

            hours = (int)(time / 60);
            mins = time % 60;

            Console.WriteLine(hours + " hours " + mins + " minutes");
        }
    }
}
