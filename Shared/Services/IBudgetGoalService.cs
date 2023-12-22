using FS.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FS.Shared.Services
{
    public interface IBudgetGoalService
    {
        Task<List<BudgetGoals>> GetBudgetGoals();
        Task AddBudgetGoal(BudgetGoals goal);
        Task UpdateBudgetGoal(BudgetGoals goal);
        Task DeleteBudgetGoal(int goalId);
    }
}
