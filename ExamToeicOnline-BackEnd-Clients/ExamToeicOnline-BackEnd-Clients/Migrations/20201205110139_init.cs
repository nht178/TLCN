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
                name: "GroupQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupQuestions", x => x.Id);
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
                    dateStart = table.Column<DateTime>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    Effort = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<Guid>(nullable: true),
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
                        name: "FK_DoExams_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
<<<<<<< HEAD:ExamToeicOnline-BackEnd-Clients/ExamToeicOnline-BackEnd-Clients/Migrations/20201205110139_init.cs
                values: new object[] { new Guid("09634b2b-6c07-4228-a2da-547f6b9becf3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(13), "nhan@gmail.com", "Nguyễn Thanh Nhân", null, "12345678" });
=======
                values: new object[] { new Guid("57a1b939-3d35-4802-af4c-56fdfd7b41ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(13), "nhan@gmail.com", "Nguyễn Thanh Nhân", null, "12345678" });
>>>>>>> Ngan:ExamToeicOnline-BackEnd-Clients/ExamToeicOnline-BackEnd-Clients/Migrations/20201206070306_init.cs

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "Email", "Fullname", "Image", "PhoneNumber" },
<<<<<<< HEAD:ExamToeicOnline-BackEnd-Clients/ExamToeicOnline-BackEnd-Clients/Migrations/20201205110139_init.cs
                values: new object[] { new Guid("68097a66-5329-440f-a3d2-d4f98ca3162d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(6), "ngan@gmail.com", "Đỗ Thị Thanh Ngân", null, "98765432" });
=======
                values: new object[] { new Guid("79e4ff06-bde4-4457-a60f-f1466d0b5a85"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(6), "ngan@gmail.com", "Đỗ Thị Thanh Ngân", null, "98765432" });
>>>>>>> Ngan:ExamToeicOnline-BackEnd-Clients/ExamToeicOnline-BackEnd-Clients/Migrations/20201206070306_init.cs

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreateAt", "Password", "UserId", "Username", "isActive", "isAdmin" },
<<<<<<< HEAD:ExamToeicOnline-BackEnd-Clients/ExamToeicOnline-BackEnd-Clients/Migrations/20201205110139_init.cs
                values: new object[] { 1, new DateTime(2020, 12, 5, 18, 1, 39, 126, DateTimeKind.Local).AddTicks(2842), "$2a$11$y9xbLt5YkIDpk/v6yOQfUu02uj0/nVMMmuUyIg6GMTw7GtR0yEQnK", new Guid("09634b2b-6c07-4228-a2da-547f6b9becf3"), "ngan", true, false });
=======
                values: new object[] { 1, new DateTime(2020, 12, 6, 14, 3, 5, 658, DateTimeKind.Local).AddTicks(6197), "$2a$11$Kc1EgViMO3yQg32Gxi/wdOVQK3K/PmSUEQuvY1TOqJx/KarIxkoM.", new Guid("57a1b939-3d35-4802-af4c-56fdfd7b41ee"), "ngan", true, false });
>>>>>>> Ngan:ExamToeicOnline-BackEnd-Clients/ExamToeicOnline-BackEnd-Clients/Migrations/20201206070306_init.cs

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreateAt", "Password", "UserId", "Username", "isActive", "isAdmin" },
<<<<<<< HEAD:ExamToeicOnline-BackEnd-Clients/ExamToeicOnline-BackEnd-Clients/Migrations/20201205110139_init.cs
                values: new object[] { 2, new DateTime(2020, 12, 5, 18, 1, 39, 126, DateTimeKind.Local).AddTicks(2842), "$2a$11$JLTGYPfSXp39GIV9/o2U0OFi8Ob3RH.DhlmPt63ijxjsU.zK364lS", new Guid("68097a66-5329-440f-a3d2-d4f98ca3162d"), "nhan", true, false });
=======
                values: new object[] { 2, new DateTime(2020, 12, 6, 14, 3, 5, 658, DateTimeKind.Local).AddTicks(6197), "$2a$11$VwM9grQuk6vLsDJIghQEFuntgbJUXw2kuyL53IBKBKn3VMKsS8qRy", new Guid("79e4ff06-bde4-4457-a60f-f1466d0b5a85"), "nhan", true, false });
>>>>>>> Ngan:ExamToeicOnline-BackEnd-Clients/ExamToeicOnline-BackEnd-Clients/Migrations/20201206070306_init.cs

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
                name: "IX_DoExams_UserId1",
                table: "DoExams",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_FileAudios_GroupQuestionId",
                table: "FileAudios",
                column: "GroupQuestionId");

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
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "GroupQuestions");
        }
    }
}
