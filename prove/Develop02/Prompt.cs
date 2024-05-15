using System.Collections.Generic;

class Prompt
{
    public List<string> prompts = new List<string>();
    public Prompt()
    {
        PromptGenerator();
    }
    public void PromptGenerator()
    {
        prompts.Add("How was your day?");
        prompts.Add("Did you do anything fun this weekend?");
        prompts.Add("What is your favorite holiday?");
        prompts.Add("What is your favorite kind of cheese?");
        prompts.Add("Did you water the plants today?");
        prompts.Add("When is your birthday?");
        prompts.Add("What's your favorite childhood memory?");
        prompts.Add("Who is your best friend?");
        prompts.Add("Why did the chicken cross the road?");
        prompts.Add("Where is your repository?");
    }

    public string GetPrompt()
    {
        if (prompts.Count == 0)
        {
            return "No prompts available.";
        }

        Random random = new Random();
        int index = random.Next(prompts.Count);
        
        return prompts[index];
    }
    
}