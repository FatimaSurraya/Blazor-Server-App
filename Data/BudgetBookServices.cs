namespace FS.Data
{
	public class BudgetBookServices
	{
		private static List<Entry> mockdb = new List<Entry>();

		public async Task<bool> AddEntry(Entry newEntry)
		{
			if (newEntry != null)
			{
				mockdb.Add(newEntry);
				return true;
			}
			return false;
		}

        public List<Entry> GetAllEntries()
        {
            return mockdb;
        }

        public bool EditEntry(Entry editedEntry)
        {
			var index = mockdb.FindIndex(e => e.Id == editedEntry.Id);
			if (index != -1)
			{
				mockdb[index] = editedEntry;
				return true;
			}
			return false;
		}

        public bool DeleteEntry(Entry entryToDelete)
        {
			var existingEntry = mockdb.FirstOrDefault(e => e.Id == entryToDelete.Id);
			if (existingEntry != null)
			{
				mockdb.Remove(existingEntry);
				return true;
			}
			return false;
		}
	}
}
