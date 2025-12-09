using System.Reflection;
using System.IO;



class GoalManager
{
    List<Goal> _goals;
    int _score;

    public GoalManager()
    {
        _score = 0;
        _goals = [];
    }
    public void Start()
    {
        bool quit = false;


        while (quit != true) {

            DisplayPlayerInfo();
        
            Console.WriteLine("Menu Options: \n  1. Create New Goal \n  2. Delete Goal \n  3. Save Goals \n  4. Load Goals \n  5. List Goals \n  6. Record Event");
            Console.Write("  7. Quit \nSelect a choice from the menu: ");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    //Create New Goals
                    CreateGoal();
                    break;

                case 2:
                    //Delete Goal
                    DeleteGoal();
                    break;

                case 3:
                    //Save Goals
                    SaveGoals();
                    break;

                case 4:
                    //Load Goals
                    LoadGoals();
                    break;

                case 5:
                    //List Goals
                    ListGoalDetails();
                    break;

                case 6:
                    //Record Event
                    RecordEvent();
                    break;
                
                case 7:
                    //Quit
                    quit = true;
                    break;
            }
        }
    }
    void DisplayPlayerInfo()
    {
        Console.WriteLine($"\n you have {_score} points. \n");
    }
    void ListGoalName()
    {
        foreach(Goal task in _goals)
        {
            string goalDetails = task.GetStringRepresentation();
            string [] goalName = goalDetails.Split(":::");
            Console.WriteLine($" {_goals.IndexOf(task) + 1}. {goalName[1]}");
        }
    }
    void ListGoalDetails()
    {
        Console.WriteLine("the goals are:");
        foreach(Goal task in _goals)
        {
            string requirements = task.GetDetailsString();
            Console.WriteLine($"{_goals.IndexOf(task) + 1}. {requirements}");
        }
    }
    void CreateGoal()
    {
        Console.Write("the types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\nWhich type of goal would you like to create?: ");
        int userInput = int.Parse(Console.ReadLine());

        Console.Write("state name of goal: ");
        string goalName = Console.ReadLine();
        Console.Write("write a short description of goal: ");
        string goalDesc = Console.ReadLine();
        Console.Write("give point amount for completion of goal: ");
        int goalPoints = int.Parse(Console.ReadLine());

        switch (userInput)
        {
            case 1:
                //Create Simple Goal
                SimpleGoal simplicity = new SimpleGoal(goalName,goalDesc,goalPoints);
                _goals.Add(simplicity);
                break;
            case 2:
                //Create Eternal Goal
                EternalGoal eternity = new EternalGoal(goalName,goalDesc,goalPoints);
                _goals.Add(eternity);
                break;
            case 3:
                //Create CheckList Goal [placed these last two here due to the other set of readline's being needed for other cases]
                Console.Write("state amount of goal completions needed for bonus: ");
                int goalTarget = int.Parse(Console.ReadLine());
                Console.Write("give bonus point amount for completion of goal: ");
                int goalBonus = int.Parse(Console.ReadLine());
                CheckListGoal checker = new CheckListGoal(goalName,goalDesc,goalPoints,goalTarget,goalBonus);
                _goals.Add(checker);
                break;
        }
    }
    void RecordEvent()
    {
        ListGoalName();
        Console.Write("state goal completed (by number): ");
        int goalCompleted = int.Parse(Console.ReadLine());

        Goal selectedGoal = _goals[goalCompleted -1];

        int reward = selectedGoal.RecordEvent();
        _score += reward;
        Console.WriteLine($"Good Job! you have earned {reward} points.\n you now have {_score} points.");
    }
    void DeleteGoal() // added this so that the goals list doesn't get too cluttered by already done goals.
    {
        ListGoalName();
        Console.Write("state goal to delete (by number): ");
        int goalCompleted = int.Parse(Console.ReadLine());

        int selectedGoal = goalCompleted -1;
        _goals.RemoveAt(selectedGoal);

        Console.WriteLine($"Good Job! you have deleted {selectedGoal} Goal.\n");
    }
    void SaveGoals()
    {
        Console.Write("state name for goal save file (NOTE: *.txt already applied): ");
        string filename= Console.ReadLine() + ".txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            
            foreach (Goal g in _goals) {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }

    }
    void LoadGoals()
    {
        _score = 0;
        _goals = [];
        Console.Write("state name for goal save file (NOTE: *.txt already applied): ");
        string filename= Console.ReadLine() + ".txt";
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            
            string[] parts = line.Split(":::");

            string goalType = parts[0];
            string shortName = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (goalType == "CheckListGoal")
            {
                int bonus = int.Parse(parts[4]);
                int amountCompleted = int.Parse(parts[5]);
                int target = int.Parse(parts[6]);

                CheckListGoal knight = new CheckListGoal(shortName,description,points,target,bonus);
                _goals.Add(knight);
                for (int l = 0; l < amountCompleted; l++)
                {
                    _score += knight.RecordEvent();
                }
            }
            if (goalType == "EternalGoal")
            {
                int completionAmount = int.Parse(parts[4]);
                EternalGoal temporal = new EternalGoal(shortName,description,points);
                _goals.Add(temporal);
                for (int l = 0; l < completionAmount; l++)
                {
                    _score += temporal.RecordEvent();
                }
            }
            if (goalType == "SimpleGoal")
            {
                bool destination = bool.Parse(parts[4]);
                SimpleGoal complexity = new SimpleGoal(shortName,description,points);
                _goals.Add(complexity);
                if (destination == true)
                {
                    _score += complexity.RecordEvent();
                }
            }
        }
    }
}