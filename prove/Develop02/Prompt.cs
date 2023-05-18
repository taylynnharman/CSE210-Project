public class Prompt {
    public string prompt()
    {
    List<string>prompts = new List<string> {
        "Who was the most interesting person I interacted with today?",
"What was the best part of my day?",
"How did I see the hand of the Lord in my life today?",
"What was the strongest emotion I felt today?",
"If I had one thing I could do over today, what would it be?",
"What lesson did you learn today?",
"How did you improve today?", 
"Who do you feel prompted to reach out to today?"};

Random random = new Random();
int index = random.Next(prompts.Count);
return (prompts[index]);
    }
}