class PromptGenerator
{
    public List<string> _prompts = new List<string> {
     "When did you last step out of your comfort zone?",
     "What’s the worst job you’ve ever had?",
     "What foods make your body feel good?",
      "When did you last feel angry? Was it 'justified'?",
       "Is your soul happy? Why?",
        "What was the last coincidence that you noticed?",
        "Think about your internal dialogue - what percentage would you describe it as positive?",
        "Think about your internal dialogue - what percentage would you describe it as negative?",
        "If you have one year left, what would you do?",
        "Does anyone know the “real” you?",
        "Who would you like to reach out to soon, and why?",
        "Do you have any investments? How does this make you feel?",
        "If you have siblings, describe your relationship now",
        "How do you feel after a night of good sleep vs. bad sleep?",
        "What did go well this month?"
                };

    List<string> _prevPrompt = new List<string>();

    Random rand = new Random();

    public string GetRandomPrompt()
    {
        string promptChoice = _prompts[rand.Next(0, 15)];
        // this randomly selects the journal prompt from the list from 0-14, 
        // this is the case because 15 isn't counted, but considered the ending number and will not be called upon
        // though with the rand.Next refering to a number it must be placed within the "[ ]" to be noted as an index location
        // this leads to the index being called and the value being extracted and placed within the variable promptChoice

        // start of addition
        // this code block checks if the Prompt generated has already been used previously in a recent point;
        // if it was reused, then it will regenerate the prompt until it changes to something different
        while (_prevPrompt.Contains(promptChoice))
        {
            promptChoice = _prompts[rand.Next(0, 15)];
        }

        _prevPrompt.Add(promptChoice);

        // this makes sure that the list doesn't get to long and also so that prompts can resume after a period of entries
        if (_prevPrompt.Count > 5)
        {
            _prevPrompt.RemoveAt(0);
        }
        // end of addition

        return promptChoice;
 
    }
}