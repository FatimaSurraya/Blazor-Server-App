using System.ComponentModel.DataAnnotations;

namespace FS.Data
{
	public class Entry
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Amount is required")]
		[Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
		public decimal Amount { get; set; }

		[Required(ErrorMessage = "Description is required")]
		[MinLength(1, ErrorMessage = "Description must not be empty")]
		public string Description { get; set; }
	}
}

