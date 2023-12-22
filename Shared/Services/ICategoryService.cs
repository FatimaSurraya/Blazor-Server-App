
using FS.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace FS.Shared.Services
{
	public interface ICategoryService
	{
	Task<List<Category>> GetCategories();
	Task<Category> GetCategoryById(int categoryId);
	Task AddCategory(Category category);
	Task UpdateCategory(Category category);
	Task DeleteCategory(int categoryId);
}
}
