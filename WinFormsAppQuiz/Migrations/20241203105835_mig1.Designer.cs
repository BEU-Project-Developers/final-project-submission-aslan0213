﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormsAppQuiz.DataAccess;

#nullable disable

namespace WinFormsAppQuiz.Migrations
{
    [DbContext(typeof(QuestionDbContext))]
    [Migration("20241203105835_mig1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WinFormsAppQuiz.Entitys.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Login = "admin",
                            Password = "12345"
                        });
                });

            modelBuilder.Entity("WinFormsAppQuiz.Entitys.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CorrectAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WrongAnswerOne")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WrongAnswerThree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WrongAnswerTwo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CorrectAnswer = "4",
                            Score = 5.0,
                            Text = "What is 2 + 2?",
                            WrongAnswerOne = "3",
                            WrongAnswerThree = "6",
                            WrongAnswerTwo = "5"
                        },
                        new
                        {
                            Id = 2,
                            CorrectAnswer = "Paris",
                            Score = 5.0,
                            Text = "What is the capital of France?",
                            WrongAnswerOne = "London",
                            WrongAnswerThree = "Madrid",
                            WrongAnswerTwo = "Berlin"
                        },
                        new
                        {
                            Id = 3,
                            CorrectAnswer = "Mars",
                            Score = 5.0,
                            Text = "Which planet is known as the Red Planet?",
                            WrongAnswerOne = "Earth",
                            WrongAnswerThree = "Jupiter",
                            WrongAnswerTwo = "Venus"
                        },
                        new
                        {
                            Id = 4,
                            CorrectAnswer = "Blue Whale",
                            Score = 5.0,
                            Text = "What is the largest mammal?",
                            WrongAnswerOne = "Elephant",
                            WrongAnswerThree = "Whale Shark",
                            WrongAnswerTwo = "Giraffe"
                        },
                        new
                        {
                            Id = 5,
                            CorrectAnswer = "100°C",
                            Score = 5.0,
                            Text = "What is the boiling point of water?",
                            WrongAnswerOne = "90°C",
                            WrongAnswerThree = "120°C",
                            WrongAnswerTwo = "80°C"
                        },
                        new
                        {
                            Id = 6,
                            CorrectAnswer = "William Shakespeare",
                            Score = 5.0,
                            Text = "Who wrote 'Romeo and Juliet'?",
                            WrongAnswerOne = "Charles Dickens",
                            WrongAnswerThree = "Mark Twain",
                            WrongAnswerTwo = "Leo Tolstoy"
                        },
                        new
                        {
                            Id = 7,
                            CorrectAnswer = "8",
                            Score = 5.0,
                            Text = "What is the square root of 64?",
                            WrongAnswerOne = "6",
                            WrongAnswerThree = "9",
                            WrongAnswerTwo = "7"
                        },
                        new
                        {
                            Id = 8,
                            CorrectAnswer = "H2O",
                            Score = 5.0,
                            Text = "What is the chemical symbol for water?",
                            WrongAnswerOne = "HO2",
                            WrongAnswerThree = "OH2",
                            WrongAnswerTwo = "O2H"
                        },
                        new
                        {
                            Id = 9,
                            CorrectAnswer = "Leonardo da Vinci",
                            Score = 5.0,
                            Text = "Who painted the Mona Lisa?",
                            WrongAnswerOne = "Vincent van Gogh",
                            WrongAnswerThree = "Claude Monet",
                            WrongAnswerTwo = "Pablo Picasso"
                        },
                        new
                        {
                            Id = 10,
                            CorrectAnswer = "Asia",
                            Score = 5.0,
                            Text = "What is the largest continent?",
                            WrongAnswerOne = "Africa",
                            WrongAnswerThree = "Antarctica",
                            WrongAnswerTwo = "Europe"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}