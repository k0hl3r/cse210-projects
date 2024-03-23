public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Run()
    {
        GetDuration();
        Start();
        End();
    }

    protected virtual void GetDuration()
    {
        Console.WriteLine();
        Console.WriteLine($"Starting {name} activity:");
        Console.WriteLine(description);
        Console.WriteLine();
        Console.Write($"Enter duration of the {name} activity in seconds: ");
        duration = int.Parse(Console.ReadLine());
    }

    protected virtual void Start()
    {
        Console.WriteLine($"Duration set to {duration} seconds.");
        Console.WriteLine();
        System.Threading.Thread.Sleep(3000);
    }

    protected virtual void End()
    {
        Console.WriteLine($"Good job! You have completed {name} activity.");
        System.Threading.Thread.Sleep(2000);
    }

    protected void AnimateNumbers()
    {
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(2000);
        Console.Write(".");
        Thread.Sleep(3000);
    }

    protected void Animate()
    {
        Console.Write("d");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("b");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("p");

        Thread.Sleep(500);

        Console.Write("\b \b");

        Console.Write("q");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("d");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("b");

        Thread.Sleep(500);

        Console.Write("\b \b");

        Console.Write("p");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("q");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("d");

        Thread.Sleep(500);

        Console.Write("\b \b");

        Console.Write("b");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("p");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("q");

        Thread.Sleep(500);

        Console.Write("\b \b");

        Console.Write("d");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("b");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("p");

        Thread.Sleep(500);

        Console.Write("\b \b");

        Console.Write("q");

        Thread.Sleep(500);

        Console.Write("\b \b");
    }
}
