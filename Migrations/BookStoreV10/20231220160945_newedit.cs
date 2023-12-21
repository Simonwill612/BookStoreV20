using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreV10.Migrations.BookStoreV10
{
    /// <inheritdoc />
    public partial class newedit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Customers",
                newName: "Imageurl");

            migrationBuilder.RenameColumn(
                name: "PublisherName",
                table: "Book",
                newName: "Publisher");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Book",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "AuthorName",
                table: "Book",
                newName: "Author");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Admin",
                newName: "Imageurl");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Customers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Imageurl",
                table: "Customers",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Publisher",
                table: "Book",
                newName: "PublisherName");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Book",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Book",
                newName: "AuthorName");

            migrationBuilder.RenameColumn(
                name: "Imageurl",
                table: "Admin",
                newName: "ImageUrl");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);
        }
    }
}
