﻿// <auto-generated />
using System;
using ExamToeicOnline_BackEnd_Clients.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExamToeicOnline_BackEnd_Clients.Migrations
{
    [DbContext(typeof(ExamToeicOnlineDBContext))]
    [Migration("20201118061632_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExamToeicOnline_BackEnd_Clients.Models.Anwser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Correct")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Anwsers");
                });

            modelBuilder.Entity("ExamToeicOnline_BackEnd_Clients.Models.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("ExamToeicOnline_BackEnd_Clients.Models.Part", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<byte[]>("FilMP3")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("ExamToeicOnline_BackEnd_Clients.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("PartId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PartId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ExamToeicOnline_FrontEnd_Clients.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2020, 11, 18, 13, 16, 31, 532, DateTimeKind.Local).AddTicks(621),
                            Password = "$2a$11$B0OJPqDjQ6gfKeJrlxQdPezi4jh94SPTEkn1HTSI4oqYwrxECH/nW",
                            UserId = new Guid("1a904231-4ddd-40ba-8d5e-7d1730d0c690"),
                            Username = "ngan",
                            isActive = true,
                            isAdmin = false
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2020, 11, 18, 13, 16, 31, 532, DateTimeKind.Local).AddTicks(621),
                            Password = "$2a$11$o7rXjyETAxCO.5Nyg.I3GunvyaFixLj1m7OYkSlsYsJol.I/3zBpm",
                            UserId = new Guid("ff000d97-ff4e-4d27-a657-e96c51425d4a"),
                            Username = "nhan",
                            isActive = true,
                            isAdmin = false
                        });
                });

            modelBuilder.Entity("ExamToeicOnline_FrontEnd_Clients.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Phonenumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1a904231-4ddd-40ba-8d5e-7d1730d0c690"),
                            Birthday = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(13),
                            Email = "nhan@gmail.com",
                            Fullname = "Nguyễn Thanh Nhân",
                            Phonenumber = 12345678
                        },
                        new
                        {
                            Id = new Guid("ff000d97-ff4e-4d27-a657-e96c51425d4a"),
                            Birthday = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(6),
                            Email = "ngan@gmail.com",
                            Fullname = "Đỗ Thị Thanh Ngân",
                            Phonenumber = 98765432
                        });
                });

            modelBuilder.Entity("ExamToeicOnline_BackEnd_Clients.Models.Anwser", b =>
                {
                    b.HasOne("ExamToeicOnline_BackEnd_Clients.Models.Question", "Question")
                        .WithMany("Anwsers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExamToeicOnline_BackEnd_Clients.Models.Part", b =>
                {
                    b.HasOne("ExamToeicOnline_BackEnd_Clients.Models.Exam", "Exam")
                        .WithMany("Parts")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExamToeicOnline_BackEnd_Clients.Models.Question", b =>
                {
                    b.HasOne("ExamToeicOnline_BackEnd_Clients.Models.Part", "Part")
                        .WithMany("Questions")
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExamToeicOnline_FrontEnd_Clients.Models.Account", b =>
                {
                    b.HasOne("ExamToeicOnline_FrontEnd_Clients.Models.User", "User")
                        .WithMany("Accounts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}