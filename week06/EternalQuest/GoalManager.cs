using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals;
    private int _score;
    private int _currentLevel;
    private int _streakCount;
    private int _comboCount;
    private List<string> _achievements;
    private const int POINTS_PER_LEVEL = 5000;
    private const int COMBO_BONUS_PERCENT = 10;
    private const int COMBO_THRESHOLD = 3;

    // Constructor
    public GoalManager()
    {
        goals = new List<Goal>();
        _score = 0;
        _currentLevel = 1;
        _streakCount = 0;
        _comboCount = 0;
        _achievements = new List<string>();
    }

    public void Start()
    {
        LoadGoals();
        bool running = true;
        while (running)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoalsPrompt();
                    break;
                case "4":
                    LoadGoalsPrompt();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    DisplayStats();
                    break;
                case "7":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
            Console.WriteLine();
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"⭐ Level {_currentLevel} | 🔥 Streak: {_streakCount} | 🎯 Combo: {_comboCount}/{COMBO_THRESHOLD}\n");
        Console.WriteLine("========== ETERNAL QUEST ==========");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Goal Event");
        Console.WriteLine("6. View Achievements");
        Console.WriteLine("7. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public void ListGoalDetails()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("\nNo goals yet. Create one!");
            return;
        }
        Console.WriteLine("\nYour Goals:");
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.GetDetails());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nWhich type of goals would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter the type of goal (1-3): ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        switch (type)
        {
            case "1":
                goal = new SimpleGoal(name, description, points);
                Console.WriteLine("Simple goal created!");
                break;
            case "2":
                goal = new EternalGoal(name, description, points);
                Console.WriteLine("Eternal goal created!");
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, description, points, target, bonus);
                Console.WriteLine("Checklist goal created!");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        if (goal != null)
        {
            goals.Add(goal);
            CheckAchievement("first_goal");
        }
    }

    public void RecordEvent()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("\nNo goals to record. Create one first!");
            return;
        }

        ListGoalNames();
        Console.Write("Which goal did you accomplish? Enter the goal number: ");

        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= goals.Count)
        {
            Goal goal = goals[choice - 1];
            int pointsEarned = goal.GetPoints();
            goal.RecordEvent();

            _streakCount++;
            _comboCount++;

            // Check combo bonus
            int comboBonus = 0;
            if (_comboCount >= COMBO_THRESHOLD)
            {
                comboBonus = (pointsEarned * COMBO_BONUS_PERCENT) / 100;
                Console.WriteLine($"🎉 COMBO BONUS! +{comboBonus} extra points!");
                _comboCount = 0; // Reset combo
            }

            // Check if checklist goal completed
            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                pointsEarned += GetBonusPoints(checklistGoal);
                Console.WriteLine($"Congratulations! You have accomplished all of the goal. You received a bonus of {GetBonusPoints(checklistGoal)} points!");
                CheckAchievement("checklist_master");
            }

            // Check eternal goal milestone
            if (goal is EternalGoal)
            {
                CheckAchievement("eternal_devotee");
            }

            _score += pointsEarned + comboBonus;
            Console.WriteLine($"Event recorded for '{goal.GetName()}'! You earned {pointsEarned + comboBonus} points.");

            CheckLevelUp();
            CheckAchievement("century_club");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    private void CheckLevelUp()
    {
        // Calculate new level based on points
        int newLevel = (_score / POINTS_PER_LEVEL) + 1;
        if (newLevel > _currentLevel)
        {
            _currentLevel = newLevel;
            Console.WriteLine($"\n🎊 LEVEL UP! You are now level {_currentLevel}! 🎊\n");
            CheckAchievement($"level_{_currentLevel}");
        }
    }

    private void CheckAchievement(string achievementId)
    {
        string achievementName = "";

        switch (achievementId)
        {
            case "first_goal":
                if (_achievements.Contains("first_goal")) return;
                achievementName = "🏆 First Step - Complete your first goal!";
                break;
            case "century_club":
                if (_score >= 100 && !_achievements.Contains("century_club"))
                {
                    achievementName = "💯 Century Club - Reach 100 points!";
                }
                else return;
                break;
            case "eternal_devotee":
                if (!_achievements.Contains("eternal_devotee"))
                {
                    achievementName = "♾️ Eternal Devotee - Complete an eternal goal!";
                }
                else return;
                break;
            case "checklist_master":
                if (!_achievements.Contains("checklist_master"))
                {
                    achievementName = "✅ Checklist Master - Complete a checklist goal!";
                }
                else return;
                break;
            case "level_5":
                if (_currentLevel >= 5 && !_achievements.Contains("level_5"))
                {
                    achievementName = "⭐ Rising Star - Reach level 5!";
                }
                else return;
                break;
            case "level_10":
                if (_currentLevel >= 10 && !_achievements.Contains("level_10"))
                {
                    achievementName = "🌟 Legend in the Making - Reach level 10!";
                }
                else return;
                break;
            case "level_20":
                if (_currentLevel >= 20 && !_achievements.Contains("level_20"))
                {
                    achievementName = "👑 Grand Master - Reach level 20!";
                }
                else return;
                break;
            default:
                return;
        }

        if (achievementName != "" && !_achievements.Contains(achievementId))
        {
            _achievements.Add(achievementId);
            Console.WriteLine($"\n✨ ACHIEVEMENT UNLOCKED: {achievementName} ✨\n");
        }
    }

    private int GetBonusPoints(ChecklistGoal goal)
    {
        string[] parts = goal.GetStringRepresentation().Split('|');
        if (parts.Length >= 6)
        {
            return int.Parse(parts[5]);
        }
        return 0;
    }

    public void DisplayStats()
    {
        Console.WriteLine("\n========== YOUR ACHIEVEMENTS ==========");
        if (_achievements.Count == 0)
        {
            Console.WriteLine("No achievements yet. Keep playing!");
        }
        else
        {
            foreach (string achievement in _achievements)
            {
                switch (achievement)
                {
                    case "first_goal":
                        Console.WriteLine("🏆 First Step");
                        break;
                    case "century_club":
                        Console.WriteLine("💯 Century Club");
                        break;
                    case "eternal_devotee":
                        Console.WriteLine("♾️ Eternal Devotee");
                        break;
                    case "checklist_master":
                        Console.WriteLine("✅ Checklist Master");
                        break;
                    case "level_5":
                        Console.WriteLine("⭐ Rising Star");
                        break;
                    case "level_10":
                        Console.WriteLine("🌟 Legend in the Making");
                        break;
                    case "level_20":
                        Console.WriteLine("👑 Grand Master");
                        break;
                }
            }
        }
        Console.WriteLine($"\nCurrent Level: {_currentLevel}");
        Console.WriteLine($"Current Points: {_score}");
        Console.WriteLine($"Points to Next Level: {POINTS_PER_LEVEL - (_score % POINTS_PER_LEVEL)}");
        Console.WriteLine("=====================================");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
        }
    }

    public void SaveGoalsPrompt()
    {
        Console.Write("What is the filename for the goals file? ");
        string filename = Console.ReadLine();
        SaveGoals(filename);
    }

    public void SaveGoals(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score);
                writer.WriteLine(_currentLevel);
                writer.WriteLine(_streakCount);
                writer.WriteLine(string.Join(",", _achievements));
                foreach (Goal goal in goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine($"Goals saved to {filename}!");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error saving goals: {e.Message}");
        }
    }

    public void LoadGoalsPrompt()
    {
        Console.Write("What is the filename for the goals file? ");
        string filename = Console.ReadLine();
        LoadGoals(filename);
    }

    public void LoadGoals()
    {
        LoadGoals("goals.txt");
    }

    public void LoadGoals(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine($"File '{filename}' not found.");
                return;
            }

            goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string scoreLine = reader.ReadLine();
                if (scoreLine != null && int.TryParse(scoreLine, out int score))
                {
                    _score = score;
                }

                string levelLine = reader.ReadLine();
                if (levelLine != null && int.TryParse(levelLine, out int level))
                {
                    _currentLevel = level;
                }

                string streakLine = reader.ReadLine();
                if (streakLine != null && int.TryParse(streakLine, out int streak))
                {
                    _streakCount = streak;
                }

                string achievementLine = reader.ReadLine();
                if (achievementLine != null && achievementLine.Length > 0)
                {
                    _achievements = new List<string>(achievementLine.Split(','));
                }

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length > 0)
                    {
                        string goalType = parts[0];

                        switch (goalType)
                        {
                            case "SimpleGoal":
                                if (parts.Length >= 4)
                                {
                                    SimpleGoal simple = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                                    if (parts.Length >= 5 && bool.TryParse(parts[4], out bool isComplete))
                                    {
                                        if (isComplete)
                                        {
                                            simple.RecordEvent();
                                        }
                                    }
                                    goals.Add(simple);
                                }
                                break;
                            case "EternalGoal":
                                if (parts.Length >= 4)
                                {
                                    EternalGoal eternal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                                    if (parts.Length >= 5 && int.TryParse(parts[4], out int timesCompleted))
                                    {
                                        for (int i = 0; i < timesCompleted; i++)
                                        {
                                            eternal.RecordEvent();
                                        }
                                    }
                                    goals.Add(eternal);
                                }
                                break;
                            case "ChecklistGoal":
                                if (parts.Length >= 7)
                                {
                                    ChecklistGoal checklist = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                                                                                 int.Parse(parts[4]), int.Parse(parts[5]));
                                    int amountCompleted = int.Parse(parts[6]);
                                    for (int i = 0; i < amountCompleted; i++)
                                    {
                                        checklist.RecordEvent();
                                    }
                                    goals.Add(checklist);
                                }
                                break;
                        }
                    }
                }
            }
            Console.WriteLine($"Goals loaded from {filename}!");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading goals: {e.Message}");
        }
    }
}
