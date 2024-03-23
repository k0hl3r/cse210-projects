public class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void Start()
    {
        base.Start();
        Console.WriteLine("Prepare to begin breathing exercise...");
        Animate();
        for (int i = 0; i < duration; i += 6)
        {
            Console.WriteLine("Breathe in");
            AnimateNumbers();
            Console.WriteLine();
            Console.WriteLine("Breathe out");
            AnimateNumbers();
            Console.WriteLine();
        }
    }
}