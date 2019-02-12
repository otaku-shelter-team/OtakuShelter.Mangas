using Microsoft.Extensions.DependencyInjection;

namespace OtakuShelter.Manga
{
	public static class MangaDataServices
	{
		public static IServiceCollection AddDataServices(
			this IServiceCollection services,
			MangaContextConfiguration mangaContext)
		{
			services.AddDbContextPool<MangaContext>(options => 
				MangaContextFactory.ConfigureContext(options, mangaContext));
			
			return services;
		}
	}
}