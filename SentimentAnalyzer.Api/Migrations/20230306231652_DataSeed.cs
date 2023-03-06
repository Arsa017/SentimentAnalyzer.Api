using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SentimentAnalyzer.Api.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Lexicon",
                columns: new[] { "Id", "SentimentScore", "Word" },
                values: new object[,]
                {
                    { 1, "0.4", "nice" },
                    { 2, "0.8", "excellent" },
                    { 3, "0", "modest" },
                    { 4, "-0.8", "horrible" },
                    { 5, "-0.5", "ugly" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lexicon",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lexicon",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lexicon",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lexicon",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lexicon",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
