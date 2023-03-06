﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SentimentAnalyzer.Api.DbContexts;

#nullable disable

namespace SentimentAnalyzer.Api.Migrations
{
    [DbContext(typeof(LexiconContext))]
    [Migration("20230306231652_DataSeed")]
    partial class DataSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SentimentAnalyzer.Api.Entities.Lexicon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SentimentScore")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Word")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Word")
                        .IsUnique();

                    b.ToTable("Lexicon");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SentimentScore = "0.4",
                            Word = "nice"
                        },
                        new
                        {
                            Id = 2,
                            SentimentScore = "0.8",
                            Word = "excellent"
                        },
                        new
                        {
                            Id = 3,
                            SentimentScore = "0",
                            Word = "modest"
                        },
                        new
                        {
                            Id = 4,
                            SentimentScore = "-0.8",
                            Word = "horrible"
                        },
                        new
                        {
                            Id = 5,
                            SentimentScore = "-0.5",
                            Word = "ugly"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
