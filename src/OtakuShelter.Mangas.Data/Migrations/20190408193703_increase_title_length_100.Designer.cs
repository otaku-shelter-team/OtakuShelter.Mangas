﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OtakuShelter.Mangas;

namespace OtakuShelter.Mangas.Migrations
{
    [DbContext(typeof(MangasContext))]
    [Migration("20190408193703_increase_title_length_100")]
    partial class increase_title_length_100
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("OtakuShelter.Mangas.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("ux_authors_name");

                    b.ToTable("authors");
                });

            modelBuilder.Entity("OtakuShelter.Mangas.Bookmark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AccountId")
                        .HasColumnName("account_id");

                    b.Property<int?>("ChapterId")
                        .HasColumnName("chapter_id");

                    b.Property<DateTime>("Created")
                        .HasColumnName("created");

                    b.Property<int>("MangaId")
                        .HasColumnName("manga_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.Property<int?>("PageId")
                        .HasColumnName("page_id");

                    b.HasKey("Id");

                    b.HasIndex("ChapterId");

                    b.HasIndex("MangaId");

                    b.HasIndex("PageId");

                    b.HasIndex("AccountId", "MangaId", "ChapterId", "PageId")
                        .IsUnique()
                        .HasName("UQ_accountid_mangaid_chapterid_pageid");

                    b.ToTable("bookmarks");
                });

            modelBuilder.Entity("OtakuShelter.Mangas.Chapter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("MangaId")
                        .HasColumnName("manga_id");

                    b.Property<int>("Order")
                        .HasColumnName("order");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasMaxLength(100);

                    b.Property<DateTime>("UploadDate")
                        .HasColumnName("upload_date")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("MangaId", "Order")
                        .IsUnique()
                        .HasName("UQ_mangaid_order");

                    b.ToTable("chapters");
                });

            modelBuilder.Entity("OtakuShelter.Mangas.Manga", b =>
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
                        .HasMaxLength(300);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasMaxLength(200);

                    b.Property<int>("TypeId")
                        .HasColumnName("type_id");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("mangas");
                });

            modelBuilder.Entity("OtakuShelter.Mangas.MangaAuthor", b =>
                {
                    b.Property<int>("MangaId")
                        .HasColumnName("manga_id");

                    b.Property<int>("AuthorId")
                        .HasColumnName("author_id");

                    b.HasKey("MangaId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("manga_authors");
                });

            modelBuilder.Entity("OtakuShelter.Mangas.MangaTag", b =>
                {
                    b.Property<int>("TagId")
                        .HasColumnName("tag_id");

                    b.Property<int>("MangaId")
                        .HasColumnName("manga_id");

                    b.HasKey("TagId", "MangaId");

                    b.HasIndex("MangaId");

                    b.ToTable("manga_tags");
                });

            modelBuilder.Entity("OtakuShelter.Mangas.MangaTranslator", b =>
                {
                    b.Property<int>("MangaId")
                        .HasColumnName("manga_id");

                    b.Property<int>("TranslatorId")
                        .HasColumnName("translator_id");

                    b.HasKey("MangaId", "TranslatorId");

                    b.HasIndex("TranslatorId");

                    b.ToTable("manga_translators");
                });

            modelBuilder.Entity("OtakuShelter.Mangas.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ChapterId")
                        .HasColumnName("chapter_id");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnName("image")
                        .HasMaxLength(300);

                    b.Property<int>("Order")
                        .HasColumnName("order");

                    b.HasKey("Id");

                    b.HasIndex("ChapterId", "Order")
                        .IsUnique()
                        .HasName("UQ_chapter_id_order");

                    b.ToTable("pages");
                });

            modelBuilder.Entity("OtakuShelter.Mangas.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("ux_tags_name");

                    b.ToTable("tags");
                });

            modelBuilder.Entity("OtakuShelter.Mangas.Translator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("ux_translators_name");

                    b.ToTable("translators");
                });

            modelBuilder.Entity("OtakuShelter.Mangas.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("ux_types_name");

                    b.ToTable("types");
                });

            modelBuilder.Entity("OtakuShelter.Mangas.Bookmark", b =>
                {
                    b.HasOne("OtakuShelter.Mangas.Chapter", "Chapter")
                        .WithMany("Bookmarks")
                        .HasForeignKey("ChapterId")
                        .HasConstraintName("FK_chapter_bookmarks")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OtakuShelter.Mangas.Manga", "Manga")
                        .WithMany("Bookmarks")
                        .HasForeignKey("MangaId")
                        .HasConstraintName("FK_manga_bookmarks")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OtakuShelter.Mangas.Page", "Page")
                        .WithMany("Bookmarks")
                        .HasForeignKey("PageId")
                        .HasConstraintName("FK_page_bookmarks")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OtakuShelter.Mangas.Chapter", b =>
                {
                    b.HasOne("OtakuShelter.Mangas.Manga", "Manga")
                        .WithMany("Chapters")
                        .HasForeignKey("MangaId")
                        .HasConstraintName("FK_manga_chapters")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OtakuShelter.Mangas.Manga", b =>
                {
                    b.HasOne("OtakuShelter.Mangas.Type", "Type")
                        .WithMany("Mangas")
                        .HasForeignKey("TypeId")
                        .HasConstraintName("FK_type_mangas")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OtakuShelter.Mangas.MangaAuthor", b =>
                {
                    b.HasOne("OtakuShelter.Mangas.Author", "Author")
                        .WithMany("Mangas")
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("FK_author_manga_authors")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OtakuShelter.Mangas.Manga", "Manga")
                        .WithMany("Authors")
                        .HasForeignKey("MangaId")
                        .HasConstraintName("FK_manga_manga_authors")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OtakuShelter.Mangas.MangaTag", b =>
                {
                    b.HasOne("OtakuShelter.Mangas.Manga", "Manga")
                        .WithMany("Tags")
                        .HasForeignKey("MangaId")
                        .HasConstraintName("FK_manga_manga_tags")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OtakuShelter.Mangas.Tag", "Tag")
                        .WithMany("Mangas")
                        .HasForeignKey("TagId")
                        .HasConstraintName("FK_tag_manga_tags")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OtakuShelter.Mangas.MangaTranslator", b =>
                {
                    b.HasOne("OtakuShelter.Mangas.Manga", "Manga")
                        .WithMany("Translators")
                        .HasForeignKey("MangaId")
                        .HasConstraintName("FK_manga_manga_translators")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OtakuShelter.Mangas.Translator", "Translator")
                        .WithMany("Mangas")
                        .HasForeignKey("TranslatorId")
                        .HasConstraintName("FK_translator_manga_translators")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OtakuShelter.Mangas.Page", b =>
                {
                    b.HasOne("OtakuShelter.Mangas.Chapter", "Chapter")
                        .WithMany("Pages")
                        .HasForeignKey("ChapterId")
                        .HasConstraintName("FK_chapter_pages")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
