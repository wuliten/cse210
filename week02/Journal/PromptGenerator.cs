public class PromptGenerator
{
    static List<string> _prompts = new List<string>();
    

    public string GetRandomPrompt()
    {
        _prompts.Add("What challenge did you overcome today?");
        _prompts.Add("What did you pray for today?");
        _prompts.Add("What did you want to get done today that you still need to do?");
        _prompts.Add("Where did you go today?");
        _prompts.Add("Who did you serve today?");
        Random randomGenerator = new Random();
        int numb = randomGenerator.Next(0, _prompts.Count);
        return _prompts[numb];
    }
}