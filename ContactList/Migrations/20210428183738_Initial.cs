using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactList.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: true),
                    Patronymic = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Company = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: false),
                    DopPhone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DopEmail = table.Column<string>(nullable: true),
                    Skype = table.Column<string>(nullable: true),
                    DopSkype = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactModel");
        }
    }
}
