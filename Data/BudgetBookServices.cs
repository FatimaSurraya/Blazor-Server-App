using FS.Pages;
using Microsoft.EntityFrameworkCore;

namespace FS.Data
{
    public class BudgetBookServices
	{
		private readonly ApplicationDbContext _context;
		public BudgetBookServices(ApplicationDbContext _context) {
			this._context = _context;

        }
        private static List<Entry> budget = new List<Entry>();

		public async Task<bool> AddEntry(Entry newEntry)
        {
			if (newEntry != null)
			{
				if (newEntry.Id != 0)
				{
					_context.Entries.Update(newEntry);
                }
				else
				{
					await _context.Entries.AddAsync(newEntry);
					budget.Add(newEntry);
				}
                _context.SaveChanges();
                return true;
			}
			return false;
		}

        public List<Entry> GetAllEntries()
        {
            budget = _context.Entries.AsNoTracking().ToList();
            return budget;
        }

        public bool EditEntry(Entry editedEntry)
        {
			var index = budget.FindIndex(e => e.Id == editedEntry.Id);
			if (index != -1)
			{
				budget[index] = editedEntry;
				return true;
			}
			return false;
		}

        public bool DeleteEntry(Entry entryToDelete)
        {
			var existingEntry = budget.FirstOrDefault(e => e.Id == entryToDelete.Id);
			if (existingEntry != null)
			{
				budget.Remove(existingEntry);
				return true;
			}
			return false;
		}
	}
}
