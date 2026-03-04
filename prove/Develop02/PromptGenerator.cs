using System;

public class PromptGenerator
{
    private List<string> prompts = new List<string>()
    {
        "What is one small win I had today?",
        "What is sonething that I am grateful for today?",
        "What mentally drained me today?",
        "What mentally uplifted me today?",
        "What is one thing that I learned today?",
        "What is one thing that I did that moved me closer to my goals?"
    };

    private Random random = new Random();
        public string GetRandomPrompt()
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}