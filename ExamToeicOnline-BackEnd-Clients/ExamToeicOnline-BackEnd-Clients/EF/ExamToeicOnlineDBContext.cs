﻿using ExamToeicOnline_BackEnd_Clients.Models;
using ExamToeicOnline_FrontEnd_Clients.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;


namespace ExamToeicOnline_BackEnd_Clients.EF
{
    public class ExamToeicOnlineDBContext : DbContext
    {
      
        public ExamToeicOnlineDBContext(DbContextOptions options) : base(options)
        {
           
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //   optionsBuilder.UseSqlServer("Server =.; Database = ExamToeicOnlineDb; Trusted_Connection = True;");

        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed data
            modelBuilder.Seed();
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
   
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Anwser> Anwsers { get; set; }
        public DbSet<GroupQuestion> GroupQuestions { get; set; }
        public DbSet<DoExam> DoExams { get; set; }
        public DbSet<FileAudio> FileAudios { get; set; }
        public DbSet<Paragraph> Paragraphs { get; set; }
        public DbSet<Score> Scores { get; set; }



    }
}
