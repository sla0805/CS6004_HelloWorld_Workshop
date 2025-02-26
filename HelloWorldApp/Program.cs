using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Hello, World!");
                Console.Write("Please enter your username: ");
                string username = Console.ReadLine();
                Console.WriteLine($"Hello, {username}.");
                Console.WriteLine("Do you want to exit the program? (y/n)");
                string response = Console.ReadLine();

                if (response == "y")
                {
                    loop = false;
                }
            }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey(); // Wait for user input before closing
        }
    }
}
