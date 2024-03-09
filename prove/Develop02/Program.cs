using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("\n1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Select an option (1-5): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                DateTime currentDate = DateTime.Now;
                string randomPrompt = PromptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {randomPrompt}");
                Console.Write("Enter your response: ");
                string response = Console.ReadLine();
                Entry newEntry = new Entry(currentDate, randomPrompt, response);
                journal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename to save the journal: ");
                string saveFileName = Console.ReadLine();
                journal.SaveToFile(saveFileName);
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to load the journal: ");
                string loadFileName = Console.ReadLine();
                journal.LoadFromFile(loadFileName);
            }
            else if (choice == "5")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid option. Please enter a number from 1 to 5.");
            }
        }
    }
}