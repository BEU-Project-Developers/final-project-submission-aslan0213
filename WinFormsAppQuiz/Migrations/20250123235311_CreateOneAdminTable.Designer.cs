﻿// <auto-generated />
using System;
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
    [Migration("20250123235311_CreateOneAdminTable")]
    partial class CreateOneAdminTable
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

                    b.Property<string>("Full_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            Full_Name = "System_Administrator",
                            Login = "admin",
                            Password = "12345"
                        });
                });

            modelBuilder.Entity("WinFormsAppQuiz.Entitys.OneAdmin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Full_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OneAdmin");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "amemmedov28@std.beu.edu.az",
                            Full_Name = "Aslan Memmedov Serifovic",
                            Login = "admin",
                            Password = "megamozg1302",
                            PhoneNumber = "+994 50 598 69 33"
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

                    b.Property<string>("PicturePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WrongAnswerOne")
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
                            CorrectAnswer = "- Take the child with you.",
                            Score = 5.0,
                            Text = "You have a six year old child with you in\n your car. You have just parked so you\n can collect a prescription from the \nchemist. You should -",
                            WrongAnswerOne = "- Leave the child in the car.",
                            WrongAnswerTwo = "- Ask an older person sitting nearby to watch the child."
                        },
                        new
                        {
                            Id = 2,
                            CorrectAnswer = "- No, not at any time.",
                            PicturePath = "Images\\Screenshot 2025-01-21 195447.png",
                            Score = 5.0,
                            Text = "You have just passed this sign.\n Can you park on this road ?",
                            WrongAnswerOne = "- Yes.",
                            WrongAnswerTwo = "- Yes, but only in daylight hours."
                        },
                        new
                        {
                            Id = 3,
                            CorrectAnswer = "- Move into the left lane.",
                            PicturePath = "Images\\Screenshot 2025-01-21 201128.png",
                            Score = 5.0,
                            Text = "You hear the siren of an ambulance\n approaching you from behind. You should -",
                            WrongAnswerOne = "- Slow down to the speed of other traffic.",
                            WrongAnswerTwo = "- Continue at the same speed."
                        },
                        new
                        {
                            Id = 4,
                            CorrectAnswer = "- You must obey the signs that are displayed at all times.",
                            PicturePath = "Images\\Screenshot 2025-01-21 201522.png",
                            Score = 5.0,
                            Text = "When you come across roadworks -",
                            WrongAnswerOne = "- You only have to obey the signs when there are workers about.",
                            WrongAnswerTwo = "- You only have to obey the signs during working hours."
                        },
                        new
                        {
                            Id = 5,
                            CorrectAnswer = "- No.",
                            Score = 5.0,
                            Text = "Are you allowed to use a hand-held \nmobile phone while driving a car?",
                            WrongAnswerOne = "- Yes, but only when you stop at intersections",
                            WrongAnswerTwo = "- Yes, but you must hold the steering wheel with at least one hand"
                        },
                        new
                        {
                            Id = 6,
                            CorrectAnswer = "- at least 1 metre.",
                            Score = 5.0,
                            Text = "You are driving on a road with\n a speed limit of 60km/h or less. How much space\n must you leavewhen passing a bicycle rider?-",
                            WrongAnswerOne = "at least 1.5 metres",
                            WrongAnswerTwo = "- as much as you think is safe"
                        },
                        new
                        {
                            Id = 7,
                            CorrectAnswer = "- 3 seconds",
                            PicturePath = "Images\\Screenshot 2025-01-21 202446.png",
                            Score = 5.0,
                            Text = "You should leave a gap between your vehicle and the\n one you are following. In good conditions\r\nthe gap should be -",
                            WrongAnswerOne = "- 1 second.",
                            WrongAnswerTwo = "- 2 seconds."
                        },
                        new
                        {
                            Id = 8,
                            CorrectAnswer = "- Only when the gate is up and the lights stop flashing.",
                            Score = 5.0,
                            Text = "If the boomgates are down and the signals are flashing,\n at a railway level crossing, you may begin\r\nto cross -",
                            WrongAnswerOne = " If you cannot see a train approaching.",
                            WrongAnswerTwo = "- If you can safely go around the closed gate."
                        },
                        new
                        {
                            Id = 9,
                            CorrectAnswer = "- Continue through the intersection.",
                            PicturePath = "Images\\Screenshot 2025-01-21 203045.png",
                            Score = 5.0,
                            Text = "As you drive into an intersection, the lights turn to yellow. You should -\r\n",
                            WrongAnswerOne = "- Accelerate as hard as you can",
                            WrongAnswerTwo = "- Brake immediately to a stop"
                        },
                        new
                        {
                            Id = 10,
                            CorrectAnswer = "- Before coming to and as near to the intersection as\r\npossible.",
                            Score = 5.0,
                            Text = "You drive up to an intersection with a stop sign.\n There is no painted stop line. Where should you\r\nstop?",
                            WrongAnswerOne = "- At least five metres before the intersection.",
                            WrongAnswerTwo = "- At the point where you can see clearly in both directions."
                        });
                });

            modelBuilder.Entity("WinFormsAppQuiz.Entitys.UserSession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Full_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LoginTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PassOrFail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("worth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserSession");
                });

            modelBuilder.Entity("WinFormsAppQuiz.Entitys.UsersInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Full_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassOrFail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("worth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UsersInformation");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Full_Name = "System_Administrator",
                            Login = "admin",
                            PassOrFail = "Pass",
                            worth = 5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
