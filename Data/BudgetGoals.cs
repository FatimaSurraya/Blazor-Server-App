using System.ComponentModel.DataAnnotations;

namespace FS.Data
{
    public class BudgetGoals
    {
        [Key]
        public int Id { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public DateTime StartDate { get; set; } // Start date for the budget goal
        public DateTime EndDate { get; set; } // End date for the budget goal
        public bool IsCompleted { get; set; } // Indicates if the goal is completed
    }
}
