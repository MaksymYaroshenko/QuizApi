﻿// <auto-generated />
using System;
using DAL.DbConnection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(QuizDatabaseContext))]
    [Migration("20221016123537_EmailStatistic")]
    partial class EmailStatistic
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAL.Models.EmailStatistic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("ToUserEmail")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ToUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ToUserId");

                    b.ToTable("EmailStatistic");
                });

            modelBuilder.Entity("DAL.Models.Participant", b =>
                {
                    b.Property<int>("ParticipantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParticipantId"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("TimeTaken")
                        .HasColumnType("int");

                    b.HasKey("ParticipantId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("DAL.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"), 1L, 1);

                    b.Property<int>("Answer")
                        .HasColumnType("int");

                    b.Property<string>("Option1")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Option2")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Option3")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Option4")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("QuestionImage")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("QuestionName")
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("QuestionId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("DAL.Models.EmailStatistic", b =>
                {
                    b.HasOne("DAL.Models.Participant", "Participant")
                        .WithMany()
                        .HasForeignKey("ToUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Participant");
                });
#pragma warning restore 612, 618
        }
    }
}
