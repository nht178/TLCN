﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamToeicOnline_BackEnd_Clients.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numberQuestion = table.Column<int>(nullable: false),
                    ScoreLC = table.Column<int>(nullable: false),
                    ScoreRC = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Fullname = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupQuestions_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    isActive = table.Column<bool>(nullable: false),
                    isAdmin = table.Column<bool>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoExams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartedAt = table.Column<DateTime>(nullable: false),
                    FinishedAt = table.Column<DateTime>(nullable: false),
                    ScoreListening = table.Column<int>(nullable: false),
                    ScoreReading = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    ExamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoExams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoExams_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoExams_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FileAudios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    file_Audio = table.Column<string>(nullable: true),
                    GroupQuestionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileAudios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileAudios_GroupQuestions_GroupQuestionId",
                        column: x => x.GroupQuestionId,
                        principalTable: "GroupQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Paragraphs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image_Script = table.Column<string>(nullable: true),
                    GroupQuestionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paragraphs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Paragraphs_GroupQuestions_GroupQuestionId",
                        column: x => x.GroupQuestionId,
                        principalTable: "GroupQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    PartName = table.Column<string>(nullable: true),
                    GroupQuestionId = table.Column<int>(nullable: false),
                    ExamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_GroupQuestions_GroupQuestionId",
                        column: x => x.GroupQuestionId,
                        principalTable: "GroupQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Anwsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: true),
                    Correct = table.Column<bool>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anwsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Anwsers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "Email", "Fullname", "Image", "PhoneNumber" },
                values: new object[] { new Guid("52baf0e8-b4e3-4a2d-a3cc-d1ff2c9019dd"), new DateTime(1999, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "nhan@gmail.com", "Nguyễn Thanh Nhân", null, "12345678" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "Email", "Fullname", "Image", "PhoneNumber" },
                values: new object[] { new Guid("f3aaff4f-8c93-41e9-9732-21377e3f74d5"), new DateTime(1999, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ngan@gmail.com", "Đỗ Thị Thanh Ngân", null, "98765432" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreateAt", "Password", "UserId", "Username", "isActive", "isAdmin" },
                values: new object[] { 1, new DateTime(2020, 12, 24, 19, 51, 11, 401, DateTimeKind.Local).AddTicks(72), "$2a$11$N4V9YJx5AhlVubhliW35n.wUFBSqR7TRXVZnpf2iGG8mvDeSEvqTa", new Guid("52baf0e8-b4e3-4a2d-a3cc-d1ff2c9019dd"), "ngan", true, false });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreateAt", "Password", "UserId", "Username", "isActive", "isAdmin" },
                values: new object[] { 2, new DateTime(2020, 12, 24, 19, 51, 11, 401, DateTimeKind.Local).AddTicks(72), "$2a$11$uM1GGyrOTbb.54Ra22AWC.BwhBt.4zYDwDqFJDDW78T6QZhXsQhAq", new Guid("f3aaff4f-8c93-41e9-9732-21377e3f74d5"), "nhan", true, false });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_UserId",
                table: "Accounts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Anwsers_QuestionId",
                table: "Anwsers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_DoExams_ExamId",
                table: "DoExams",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_DoExams_UserId",
                table: "DoExams",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FileAudios_GroupQuestionId",
                table: "FileAudios",
                column: "GroupQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupQuestions_ExamId",
                table: "GroupQuestions",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Paragraphs_GroupQuestionId",
                table: "Paragraphs",
                column: "GroupQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ExamId",
                table: "Questions",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_GroupQuestionId",
                table: "Questions",
                column: "GroupQuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Anwsers");

            migrationBuilder.DropTable(
                name: "DoExams");

            migrationBuilder.DropTable(
                name: "FileAudios");

            migrationBuilder.DropTable(
                name: "Paragraphs");

            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "GroupQuestions");

            migrationBuilder.DropTable(
                name: "Exams");
        }
    }
}
