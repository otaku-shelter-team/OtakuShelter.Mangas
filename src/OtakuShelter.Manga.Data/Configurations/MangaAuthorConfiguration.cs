using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OtakuShelter.Manga
{
	public class MangaAuthorConfiguration : IEntityTypeConfiguration<MangaAuthor>
	{
		public void Configure(EntityTypeBuilder<MangaAuthor> builder)
		{
			builder.ToTable("mangaauthors");
			
			builder.HasKey(mt => new { mt.MangaId, TranslatorId = mt.AuthorId });

			builder.Property(mt => mt.MangaId)
				.HasColumnName("mangaid")
				.IsRequired();

			builder.Property(mt => mt.AuthorId)
				.HasColumnName("authorid")
				.IsRequired();

			builder.HasOne(mt => mt.Manga)
				.WithMany(m => m.Authors)
				.IsRequired()
				.OnDelete(DeleteBehavior.Restrict)
				.HasConstraintName("FK_manga_mangaauthors");

			builder.HasOne(mt => mt.Author)
				.WithMany(t => t.Mangas)
				.IsRequired()
				.OnDelete(DeleteBehavior.Restrict)
				.HasConstraintName("FK_author_mangaauthors");
		}
	}
}