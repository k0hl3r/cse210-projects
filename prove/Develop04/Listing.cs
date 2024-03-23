public class Listing : Activity
{
    private string[] listingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void Start()
    {
        base.Start();
        Console.WriteLine();
        Console.WriteLine("Prepare to list...");
        Animate();

        Random rand = new Random();
        string prompt = listingPrompts[rand.Next(listingPrompts.Length)];
        Console.WriteLine();
        Console.WriteLine($"-----{prompt}-----");
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        int itemsCount = 0;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.WriteLine("Enter an item:");
            Console.ReadLine();
            itemsCount++;
        }

        Console.WriteLine($"You have listed {itemsCount} items.");
    }
}