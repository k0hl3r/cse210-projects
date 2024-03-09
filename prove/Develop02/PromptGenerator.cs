using System;

class PromptGenerator
{
    private static readonly string[] prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Did you read a book today? If so, what book?",
        "What hooby did you work on today?",
        "What did you eat today?",
        "How did you light the world today?",
        "Did you talk with anyone new today?"
    };

    public static string GetRandomPrompt()
    {
        Random random = new Random();
        return prompts[random.Next(prompts.Length)];
    }
}