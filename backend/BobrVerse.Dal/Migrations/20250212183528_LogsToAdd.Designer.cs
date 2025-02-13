﻿// <auto-generated />
using System;
using BobrVerse.Dal.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BobrVerse.Dal.Migrations
{
    [DbContext(typeof(BobrVerseContext))]
    [Migration("20250212183528_LogsToAdd")]
    partial class LogsToAdd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BobrVerse.Auth.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BobrVerse.Dal.Entities.BobrLevel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("LogsToAdd")
                        .HasColumnType("int");

                    b.Property<int>("RequiredXP")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BobrLevels");
                });

            modelBuilder.Entity("BobrVerse.Dal.Entities.BobrProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LevelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Logs")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("XP")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LevelId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("BobrProfiles");
                });

            modelBuilder.Entity("BobrVerse.Dal.Entities.Quest.Quest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("TimeLimit")
                        .HasColumnType("time");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("XpForComplete")
                        .HasColumnType("int");

                    b.Property<int>("XpForSuccess")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Quests");
                });

            modelBuilder.Entity("BobrVerse.Dal.Entities.Quest.QuestRating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BobrProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("QuestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("QuestResponseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BobrProfileId");

                    b.HasIndex("QuestId");

                    b.ToTable("QuestRatings");
                });

            modelBuilder.Entity("BobrVerse.Dal.Entities.Quest.QuestResponse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CompletedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("QuestDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("QuestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("QuestRatingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("QuestTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TotalXp")
                        .HasColumnType("int");

                    b.Property<int>("XpEarned")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.HasIndex("QuestId");

                    b.HasIndex("QuestRatingId")
                        .IsUnique()
                        .HasFilter("[QuestRatingId] IS NOT NULL");

                    b.ToTable("QuestResponses");
                });

            modelBuilder.Entity("BobrVerse.Dal.Entities.Quest.QuizTaskStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CompletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EarnedXp")
                        .HasColumnType("int");

                    b.Property<Guid>("QuestResponseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("QuizTaskId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TaskType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestResponseId");

                    b.HasIndex("QuizTaskId");

                    b.ToTable("QuizTaskStatuses");
                });

            modelBuilder.Entity("BobrVerse.Dal.Entities.Quest.Tasks.QuizTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRequiredForNextStage")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTemplate")
                        .HasColumnType("bit");

                    b.Property<int?>("MaxAttempts")
                        .HasColumnType("int");

                    b.Property<int?>("MaxCollectCalls")
                        .HasColumnType("int");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<Guid>("QuestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaskType")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("TimeLimit")
                        .HasColumnType("time");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuestId");

                    b.ToTable("QuizTasks");
                });

            modelBuilder.Entity("BobrVerse.Dal.Entities.Quest.Tasks.Resource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid?>("QuizTaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("QuizTaskId");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("BobrVerse.Dal.Entities.BobrProfile", b =>
                {
                    b.HasOne("BobrVerse.Dal.Entities.BobrLevel", "Level")
                        .WithMany()
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BobrVerse.Auth.Entities.User", "User")
                        .WithOne()
                        .HasForeignKey("BobrVerse.Dal.Entities.BobrProfile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Level");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BobrVerse.Dal.Entities.Quest.Quest", b =>
                {
                    b.HasOne("BobrVerse.Dal.Entities.BobrProfile", "Author")
                        .WithMany("CreatedQuests")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Author");
                });

            modelBuilder.Entity("BobrVerse.Dal.Entities.Quest.QuestRating", b =>
                {
                    b.HasOne("BobrVerse.Dal.Entities.BobrProfile", "BobrProfile")
                        .WithMany("QuestRatings")
                        .HasForeignKey("BobrProfileId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("BobrVerse.Dal.Entities.Quest.Quest", "Quest")
                        .WithMany("QuestRatings")
                        .HasForeignKey("QuestId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("BobrProfile");

                    b.Navigation("Quest");
                });

            modelBuilder.Entity("BobrVerse.Dal.Entities.Quest.QuestResponse", b =>
                {
                    b.HasOne("BobrVerse.Dal.Entities.BobrProfile", "Profile")
                        .WithMany("QuestResponses")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BobrVerse.Dal.Entities.Quest.Quest", "Quest")
                        .WithMany("QuestResponses")
                        .HasForeignKey("QuestId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BobrVerse.Dal.Entities.Quest.QuestRating", "QuestRating")
                        .WithOne("QuestResponse")
                        .HasForeignKey("BobrVerse.Dal.Entities.Quest.QuestResponse", "QuestRatingId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Profile");

                    b.Navigation("Quest");

                    b.Navigation("QuestRating");
                });

            modelBuilder.Entity("BobrVerse.Dal.Entities.Quest.QuizTaskStatus", b =>
                {
                    b.HasOne("BobrVerse.Dal.Entities.Quest.QuestResponse", "QuestResponse")
                        .WithMany("TaskStatuses")
                        .HasForeignKey("QuestResponseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BobrVerse.Dal.Entities.Quest.Tasks.QuizTask", "QuizTask")
                        .WithMany("TaskStatuses")
                        .HasForeignKey("QuizTaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuestResponse");

                    b.Navigation("QuizTask");
                });

            modelBuilder.Entity("BobrVerse.Dal.Entities.Quest.Tasks.QuizTask", b =>
                {
                    b.HasOne("BobrVerse.Dal.Entities.Quest.Quest", "Quest")
                        .WithMany("Tasks")
                        .HasForeignKey("QuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quest");
                });

            modelBuilder.Entity("BobrVerse.Dal.Entities.Quest.Tasks.Resource", b =>
                {
                    b.HasOne("BobrVerse.Dal.Entities.Quest.Tasks.QuizTask", null)
                        .WithMany("RequiredResources")
                        .HasForeignKey("QuizTaskId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BobrVerse.Dal.Entities.BobrProfile", b =>
                {
                    b.Navigation("CreatedQuests");

                    b.Navigation("QuestRatings");

                    b.Navigation("QuestResponses");
                });

            modelBuilder.Entity("BobrVerse.Dal.Entities.Quest.Quest", b =>
                {
                    b.Navigation("QuestRatings");

                    b.Navigation("QuestResponses");

                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("BobrVerse.Dal.Entities.Quest.QuestRating", b =>
                {
                    b.Navigation("QuestResponse");
                });

            modelBuilder.Entity("BobrVerse.Dal.Entities.Quest.QuestResponse", b =>
                {
                    b.Navigation("TaskStatuses");
                });

            modelBuilder.Entity("BobrVerse.Dal.Entities.Quest.Tasks.QuizTask", b =>
                {
                    b.Navigation("RequiredResources");

                    b.Navigation("TaskStatuses");
                });
#pragma warning restore 612, 618
        }
    }
}
