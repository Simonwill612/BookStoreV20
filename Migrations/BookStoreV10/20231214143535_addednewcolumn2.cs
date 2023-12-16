using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreV10.Migrations.BookStoreV10
{
    /// <inheritdoc />
    public partial class addednewcolumn2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Describe",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Describe",
                table: "Book");
        }
    }
}
