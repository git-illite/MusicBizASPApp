using System.ComponentModel.DataAnnotations;

namespace F2022A6AA.Data
{
	public class RoleClaim
	{
		public int Id { get; set; }

		[Required, StringLength(100)]
		public string Name { get; set; }
	}
}