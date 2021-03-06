using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace OtakuShelter.Mangas
{
	public class MangasDesignTimeDbContextFactory : IDesignTimeDbContextFactory<MangasContext>
	{
		public MangasContext CreateDbContext(string[] args)
		{
			return new ServiceCollection()
				.AddMangasDatabase(new MangasDatabaseConfiguration())
				.BuildServiceProvider()
				.GetRequiredService<MangasContext>();
		}
	}
}