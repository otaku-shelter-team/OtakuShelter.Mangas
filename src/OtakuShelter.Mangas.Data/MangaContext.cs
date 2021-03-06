using Microsoft.EntityFrameworkCore;

namespace OtakuShelter.Mangas
{
	public class MangasContext : DbContext
	{
		public MangasContext(DbContextOptions<MangasContext> options)
			: base(options)
		{
		}

		public DbSet<Author> Authors { get; set; }

		public DbSet<Bookmark> Bookmarks { get; set; }
		public DbSet<Chapter> Chapters { get; set; }
		public DbSet<MangaAuthor> MangaAuthors { get; set; }
		public DbSet<Manga> Mangas { get; set; }
		public DbSet<MangaTag> MangaTags { get; set; }
		public DbSet<MangaTranslator> MangaTranslators { get; set; }
		public DbSet<Page> Pages { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public DbSet<Translator> Translators { get; set; }
		public DbSet<Type> Types { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AuthorConfiguration());
			modelBuilder.ApplyConfiguration(new BookmarkConfiguration());
			modelBuilder.ApplyConfiguration(new ChapterConfiguration());
			modelBuilder.ApplyConfiguration(new MangaAuthorConfiguration());
			modelBuilder.ApplyConfiguration(new MangaConfiguration());
			modelBuilder.ApplyConfiguration(new MangaTagConfiguration());
			modelBuilder.ApplyConfiguration(new MangaTranslatorConfiguration());
			modelBuilder.ApplyConfiguration(new PageConfiguration());
			modelBuilder.ApplyConfiguration(new TagConfiguration());
			modelBuilder.ApplyConfiguration(new TranslatorConfiguration());
			modelBuilder.ApplyConfiguration(new TypeConfiguration());
		}
	}
}