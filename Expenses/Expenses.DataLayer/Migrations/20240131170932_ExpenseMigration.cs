using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Expenses.DataLayer.Migrations
{
    public partial class ExpenseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpenseModels",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    MoneySpent = table.Column<decimal>(nullable: false),
                    ExpenseDay = table.Column<DateTime>(nullable: false),
                    Category = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseModels", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpenseModels");
        }
    }
}
