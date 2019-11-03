using Microsoft.EntityFrameworkCore.Migrations;

namespace MyScriptureJournal.Migrations
{
    public partial class ScripturesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Scripture",
                table: "JournalEntry",
                newName: "Verse");

            migrationBuilder.AddColumn<string>(
                name: "Book",
                table: "JournalEntry",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Chapter",
                table: "JournalEntry",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Book",
                table: "JournalEntry");

            migrationBuilder.DropColumn(
                name: "Chapter",
                table: "JournalEntry");

            migrationBuilder.RenameColumn(
                name: "Verse",
                table: "JournalEntry",
                newName: "Scripture");
        }
    }
}
