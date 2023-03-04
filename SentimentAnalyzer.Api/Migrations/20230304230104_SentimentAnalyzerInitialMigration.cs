using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SentimentAnalyzer.Api.Migrations
{
    /// <inheritdoc />
    public partial class SentimentAnalyzerInitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lexicon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Word = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SentimentScore = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lexicon", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lexicon_Word",
                table: "Lexicon",
                column: "Word",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lexicon");
        }
    }
}
