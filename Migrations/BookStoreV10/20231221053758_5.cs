using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreV10.Migrations.BookStoreV10
{
    /// <inheritdoc />
    public partial class _5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "PublisherName",
                table: "Book");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorName",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PublisherName",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
