using System;

// ============================================
// ETERNAL QUEST - GAMIFIED GOAL TRACKER
// ============================================
// Features Added:
// 1. LEVELING SYSTEM: Gain levels as you accumulate points (every 5000 points = 1 level)
// 2. ACHIEVEMENT SYSTEM: Unlock badges for completing milestones:
//    - First Step: Complete your first goal
//    - Century Club: Reach 100 points
//    - Eternal Devotee: Complete an eternal goal 5 times
//    - Checklist Master: Complete a checklist goal
//    - Level Up: Reach level 5, 10, and 20
// 3. COMBO BONUS: Complete 3+ different goals in one session for a 10% point bonus
// 4. STREAK TRACKING: See your current streak of consecutive goal completions
// 5. REWARDS: Display unlocked achievements and current level/progress visually
// ============================================

class Program
{
    static void Main(string[] args)
    {
        // Create goal manager and start the application
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}