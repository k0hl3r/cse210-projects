using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Breathing breathingActivity = new Breathing();
                    breathingActivity.Run();
                    break;
                case "2":
                    Reflection reflectionActivity = new Reflection();
                    reflectionActivity.Run();
                    break;
                case "3":
                    Listing listingActivity = new Listing();
                    listingActivity.Run();
                    break;
                case "4":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}