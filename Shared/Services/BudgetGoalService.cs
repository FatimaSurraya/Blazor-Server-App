using FS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FS.Shared.Services
{
    public class BudgetGoalService : IBudgetGoalService
    {
        private readonly List<BudgetGoals> _budgetGoals = new List<BudgetGoals>();

        public async Task<List<BudgetGoals>> GetBudgetGoals()
        {
            // Fetch budget goals from the database or storage
            return _budgetGoals;
        }

        public async Task AddBudgetGoal(BudgetGoals goal)
        {
            // Implement logic to add a budget goal
            _budgetGoals.Add(goal);
        }

        public async Task UpdateBudgetGoal(BudgetGoals goal)
        {
            // Implement logic to update a budget goal
           var existingGoal = _budgetGoals.FirstOrDefault(g => g.Id == goal.Id);
            if (existingGoal != null)
            {
                existingGoal.Category = goal.Category;
                existingGoal.Amount = goal.Amount;
                // Update other properties
            }
        }

        public async Task DeleteBudgetGoal(int goalId)
        {
            // Implement logic to delete a budget goal
            var goal = _budgetGoals.FirstOrDefault(g => g.Id == goalId);
            if (goal != null)
            {
                _budgetGoals.Remove(goal);
            }
        }
    }
}
