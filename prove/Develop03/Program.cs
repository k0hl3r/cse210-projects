using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var reference1 = new Reference("John", 3, 16);
        var reference2 = new Reference("Proverbs", 3, 5-6);
        var reference3 = new Reference("Revelations", 5, 12);
        var reference4 = new Reference("2 Nephi", 4, 20);
        var reference5 = new Reference("D & C", 4, 6-7);

        var scripture1 = new Scripture(reference1, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        var scripture2 = new Scripture(reference2, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        var scripture3 = new Scripture(reference3, "Saying with a loud voice, Worthy is the Lamb that was slain to receive power, and riches, and wisdom, and strength, and honour, and glory, and blessing.");
        var scripture4 = new Scripture(reference4, "My God hath been my support; he hath led me through mine afflictions in the wilderness; and he hath preserved me upon the waters of the great deep.");
        var scripture5 = new Scripture(reference5, "Remember faith, virtue, knowledge, temperance, patience, brotherly kindness, godliness, charity, humility, diligence. Ask, and ye shall receive; knock, and it shall be opened unto you. Amen.");

        var scriptures = new List<Scripture> {scripture1, scripture2, scripture3, scripture4, scripture5};

        Random random = new Random();
        int randomIndex = random.Next(0, scriptures.Count);

        Console.WriteLine(scriptures[randomIndex].GetHiddenScripture());

        while (!scriptures[randomIndex].AllWordsHidden)
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine()?.Trim();

            if (input.ToLower() == "quit")
                break;

            scriptures[randomIndex].HideRandomWord();
            Console.Clear();
            Console.WriteLine(scriptures[randomIndex].GetHiddenScripture());
        }
    }
}
