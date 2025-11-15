class Scripture
{
    Reference _reference;
    List<Word> _words = new List<Word>();

    List<int> _prevHidden = new List<int>();

    public Scripture(Reference reference, string text)
    {
        _reference =reference;
        
        string[] inputArray = text.Split(' ');

        for (int l = 0;inputArray.Length > l; l++ )
        {
            Word newVar = new Word(inputArray[l]);
            _words.Add(newVar);
        }
    }

    public void HideRandomWords(int amountToHide) // calling this amount not number to make it clearer what it does
    {  
        Random roulette = new Random();
 

        for (int l = 0; amountToHide > l; l++)// modified this portion of code so it will never re-hide already hidden words
        {   
            int randIndex = roulette.Next(0,_words.Count);
            Word hidden = _words[randIndex];

            while (_prevHidden.Contains(randIndex) == true && _prevHidden.Count < _words.Count){ 
                // had to make this two condition if statement due to the unfortunate side-effect
                // of how the first condition locks the user into an unrecoverable loop unless they hard shut-down the program
                randIndex = roulette.Next(0,_words.Count);
                hidden = _words[randIndex];
            }
            hidden.Hide();
            _prevHidden.Add(randIndex);

        }
    }
    public string GetDisplayText()
    {   
        string wordArray = "";

        foreach(var word in _words){
            wordArray = wordArray + " " + word.GetDisplayText();
        }

        string referenceText = _reference.GetDisplayText();
        string displayText = $"{referenceText}{wordArray}";
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        bool state = false;
        int hideState = 0;

        for (int l = 0; _words.Count > l; l++ )
        {   
            Word testWord = _words[l];
            if (testWord.IsHidden() == true)
            {
                hideState++;
            }
        }
        if (hideState == _words.Count)
        {
            state = true;
        }

        return state;   
    }
}