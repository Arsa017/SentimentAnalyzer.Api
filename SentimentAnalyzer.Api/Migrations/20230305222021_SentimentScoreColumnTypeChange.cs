using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SentimentAnalyzer.Api.Migrations
{
    /// <inheritdoc />
    public partial class SentimentScoreColumnTypeChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SentimentScore",
                table: "Lexicon",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "SentimentScore",
                table: "Lexicon",
                type: "real",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
