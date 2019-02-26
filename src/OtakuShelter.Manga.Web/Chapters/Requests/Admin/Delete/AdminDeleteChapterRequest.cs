using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OtakuShelter.Manga
{
	[DataContract]
	public class AdminDeleteChapterRequest
	{
		[DataMember(Name = "chapterId")]
		public int ChapterId { get; set; }
		
		public async ValueTask Delete(MangaContext context)
		{
			var chapter = await context.Chapters
				.Include(ch => ch.Pages)
				.FirstAsync(ch => ch.Id == ChapterId);

			context.Chapters.Remove(chapter);
			context.Pages.RemoveRange(chapter.Pages);
		}
	}
}