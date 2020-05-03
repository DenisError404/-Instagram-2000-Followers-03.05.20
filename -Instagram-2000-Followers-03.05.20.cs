using System;

namespace _2000_Followers
{
    class Program
    {
        static void Main()
        {
            DateTime aDate = DateTime.Now;

            Console.WriteLine("By Denis Rafi");
            Console.WriteLine("--------------");

            Console.WriteLine("2000 Followers Thank You");
            Console.WriteLine("---------------------------");

            Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine("-----------------------------");

            Console.ReadKey();
        }       
    }
}
