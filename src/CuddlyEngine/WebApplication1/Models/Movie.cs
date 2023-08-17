using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
	public class Movie
	{
		public int Id { get; set; }

		[StringLength(90, MinimumLength = 2)]
		[Required]
		public string? Title { get; set; }

		[Display(Name = "Release Date"), DataType(DataType.Date)]
		public DateTime ReleaseDate { get; set; }

		[RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), StringLength(25)]
		[Required]
		public string? Genre { get; set; }

		[Range(1, 100), DataType(DataType.Currency)]
		[Column(TypeName = "decimal(18, 2)")]
		public decimal Price { get; set; } = decimal.Zero;

		[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(10)]
		[Required]
		public string Rating { get; set; } = string.Empty;
	}
}
