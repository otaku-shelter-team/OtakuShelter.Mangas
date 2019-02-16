﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OtakuShelter.Manga;

namespace OtakuShelter.Manga.Migrations
{
    [DbContext(typeof(MangaContext))]
    partial class MangaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("OtakuShelter.Manga.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("authors");
                });

            modelBuilder.Entity("OtakuShelter.Manga.Bookmark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AccountId")
                        .HasColumnName("accountid");

                    b.Property<int?>("ChapterId")
                        .IsRequired()
                        .HasColumnName("chapterid");

                    b.Property<DateTime>("Created")
                        .HasColumnName("created");

                    b.Property<int>("MangaId")
                        .HasColumnName("mangaid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.Property<int?>("PageId")
                        .IsRequired()
                        .HasColumnName("pageid");

                    b.HasKey("Id");

                    b.HasIndex("ChapterId");

                    b.HasIndex("MangaId");

                    b.HasIndex("PageId");

                    b.HasIndex("AccountId", "MangaId", "ChapterId", "PageId")
                        .IsUnique()
                        .HasName("UQ_accountid_mangaid_chapterid_pageid");

                    b.ToTable("bookmarks");
                });

            modelBuilder.Entity("OtakuShelter.Manga.Chapter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("MangaId")
                        .HasColumnName("mangaid");

                    b.Property<int>("Order")
                        .HasColumnName("order");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UploadDate")
                        .HasColumnName("uploaddate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("MangaId", "Order")
                        .IsUnique()
                        .HasName("UQ_mangaid_order");

                    b.ToTable("chapters");
                });

            modelBuilder.Entity("OtakuShelter.Manga.Manga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasMaxLength(2000);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnName("image")
                        .HasMaxLength(100);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasMaxLength(50);

                    b.Property<int>("TypeId")
                        .HasColumnName("typeid");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("mangas");
                });

            modelBuilder.Entity("OtakuShelter.Manga.MangaAuthor", b =>
                {
                    b.Property<int>("MangaId")
                        .HasColumnName("mangaid");

                    b.Property<int>("AuthorId")
                        .HasColumnName("authorid");

                    b.HasKey("MangaId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("mangaauthors");
                });

            modelBuilder.Entity("OtakuShelter.Manga.MangaTag", b =>
                {
                    b.Property<int>("TagId")
                        .HasColumnName("tagid");

                    b.Property<int>("MangaId")
                        .HasColumnName("mangaid");

                    b.HasKey("TagId", "MangaId");

                    b.HasIndex("MangaId");

                    b.ToTable("mangatags");
                });

            modelBuilder.Entity("OtakuShelter.Manga.MangaTranslator", b =>
                {
                    b.Property<int>("MangaId")
                        .HasColumnName("mangaid");

                    b.Property<int>("TranslatorId")
                        .HasColumnName("translatorid");

                    b.HasKey("MangaId", "TranslatorId");

                    b.HasIndex("TranslatorId");

                    b.ToTable("mangatranslators");
                });

            modelBuilder.Entity("OtakuShelter.Manga.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ChapterId")
                        .HasColumnName("chapterid");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnName("image")
                        .HasMaxLength(50);

                    b.Property<int>("Order")
                        .HasColumnName("order");

                    b.HasKey("Id");

                    b.HasIndex("ChapterId", "Order")
                        .IsUnique()
                        .HasName("UQ_chapterid_order");

                    b.ToTable("pages");
                });

            modelBuilder.Entity("OtakuShelter.Manga.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("tags");
                });

            modelBuilder.Entity("OtakuShelter.Manga.Translator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("translators");
                });

            modelBuilder.Entity("OtakuShelter.Manga.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("types");
                });

            modelBuilder.Entity("OtakuShelter.Manga.Bookmark", b =>
                {
                    b.HasOne("OtakuShelter.Manga.Chapter", "Chapter")
                        .WithMany("Bookmarks")
                        .HasForeignKey("ChapterId")
                        .HasConstraintName("FK_chapter_bookmarks")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OtakuShelter.Manga.Manga", "Manga")
                        .WithMany("Bookmarks")
                        .HasForeignKey("MangaId")
                        .HasConstraintName("FK_manga_bookmarks")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OtakuShelter.Manga.Page", "Page")
                        .WithMany("Bookmarks")
                        .HasForeignKey("PageId")
                        .HasConstraintName("FK_page_bookmarks")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OtakuShelter.Manga.Chapter", b =>
                {
                    b.HasOne("OtakuShelter.Manga.Manga", "Manga")
                        .WithMany("Chapters")
                        .HasForeignKey("MangaId")
                        .HasConstraintName("FK_manga_chapters")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OtakuShelter.Manga.Manga", b =>
                {
                    b.HasOne("OtakuShelter.Manga.Type", "Type")
                        .WithMany("Mangas")
                        .HasForeignKey("TypeId")
                        .HasConstraintName("FK_type_mangas")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OtakuShelter.Manga.MangaAuthor", b =>
                {
                    b.HasOne("OtakuShelter.Manga.Author", "Author")
                        .WithMany("Mangas")
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("FK_author_mangaauthors")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OtakuShelter.Manga.Manga", "Manga")
                        .WithMany("Authors")
                        .HasForeignKey("MangaId")
                        .HasConstraintName("FK_manga_mangaauthors")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OtakuShelter.Manga.MangaTag", b =>
                {
                    b.HasOne("OtakuShelter.Manga.Manga", "Manga")
                        .WithMany("Tags")
                        .HasForeignKey("MangaId")
                        .HasConstraintName("FK_manga_mangatags")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OtakuShelter.Manga.Tag", "Tag")
                        .WithMany("Mangas")
                        .HasForeignKey("TagId")
                        .HasConstraintName("FK_tag_mangatags")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OtakuShelter.Manga.MangaTranslator", b =>
                {
                    b.HasOne("OtakuShelter.Manga.Manga", "Manga")
                        .WithMany("Translators")
                        .HasForeignKey("MangaId")
                        .HasConstraintName("FK_manga_mangatranslators")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OtakuShelter.Manga.Translator", "Translator")
                        .WithMany("Mangas")
                        .HasForeignKey("TranslatorId")
                        .HasConstraintName("FK_translator_mangatranslators")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OtakuShelter.Manga.Page", b =>
                {
                    b.HasOne("OtakuShelter.Manga.Chapter", "Chapter")
                        .WithMany("Pages")
                        .HasForeignKey("ChapterId")
                        .HasConstraintName("FK_chapter_pages")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
