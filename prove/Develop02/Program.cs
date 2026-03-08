using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
           Console.WriteLine("Journal");
           Console.WriteLine("1). Write a new entry");
           Console.WriteLine("2). Display journal");
           Console.WriteLine("3). Save entry");
           Console.WriteLine("4). Load entry");
           Console.WriteLine("5). Quit");
           Console.WriteLine();
           Console.Write("Choose an option: ");

           string choice = Console.ReadLine();

           switch (choice)
            {
                case "1":
                    NewEntry(journal, promptGenerator);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter a filename to save to: ");
                    string save = Console.ReadLine();
                    journal.SaveToFile(save);
                    break;

                case "4":
                    Console.Write("Enter a filename to load: ");
                    string load = Console.ReadLine();
                    journal.LoadFromFile(load);
                    break;
                
                case "5":
                    running = false;
                    break;
            }
        }
    }

    static void NewEntry (Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine();
        Console.Write("Response: ");
        string response = Console.ReadLine();
        string category = ChooseCategory();
        string date = DateTime.Now.ToShortDateString();
        Entry entry = new Entry(date, prompt, response, category);

        journal.AddEntry(entry);
        Console.WriteLine("Entry added");
        Console.WriteLine();
    }

// This is my choose category function which saves the journal entry as one of these 6 categories and will be labeled as the category you choose.
    static string ChooseCategory()
    {
        Console.WriteLine("Choose a category: ");
        Console.WriteLine("1). School");
        Console.WriteLine("2). Family");
        Console.WriteLine("3). Spiritual");
        Console.WriteLine("4). Work");
        Console.WriteLine("5). Health");
        Console.WriteLine("6). Other");
        Console.WriteLine();
        Console.Write("Category (1-6): ");
        Console.WriteLine();

        string choice = Console.ReadLine();

        return choice switch
        {
            "1" => "School",
            "2" => "Family",
            "3" => "Spiritual",
            "4" => "Work",
            "5" => "Health",
            "6" => "Other",
            _ => "Other"
        };
    }
}