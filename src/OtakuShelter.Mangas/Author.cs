using System.Collections.Generic;

namespace OtakuShelter.Mangas
{
	public class Author
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public virtual ICollection<MangaAuthor> Mangas { get; set; }
	}
}