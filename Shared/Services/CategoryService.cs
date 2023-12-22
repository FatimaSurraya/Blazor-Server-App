
using FS.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace FS.Shared.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly List<Category> _categories = new List<Category>(); // Placeholder for a real database

		public async Task<List<Category>> GetCategories()
		{
			// Fetch categories from the database or storage
			return _categories;
		}

		public async Task<Category> GetCategoryById(int categoryId)
		{
			return _categories.FirstOrDefault(c => c.Id == categoryId);
		}

		public async Task AddCategory(Category category)
		{
			// Simulate generating Id for the new category (In a real app, Id might come from the database)
			category.Id = _categories.Count + 1;
			_categories.Add(category);
		}

		public async Task UpdateCategory(Category updatedCategory)
		{
			var existingCategory = _categories.FirstOrDefault(c => c.Id == updatedCategory.Id);
			if (existingCategory != null)
			{
				existingCategory.Name = updatedCategory.Name;
				// Update other properties as needed
			}
		}

		public async Task DeleteCategory(int categoryId)
		{
			var category = _categories.FirstOrDefault(c => c.Id == categoryId);
			if (category != null)
			{
				_categories.Remove(category);
			}
		}
	}

}
