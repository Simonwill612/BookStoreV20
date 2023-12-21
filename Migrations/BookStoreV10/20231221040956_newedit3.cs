using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreV10.Migrations.BookStoreV10
{
    /// <inheritdoc />
    public partial class newedit3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_AuthorNameNavigationAuthorId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Publisher_PublisherNameNavigationPublisherId",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "PublisherNameNavigationPublisherId",
                table: "Book",
                newName: "PublisherId1");

            migrationBuilder.RenameColumn(
                name: "Publisher",
                table: "Book",
                newName: "PublisherId");

            migrationBuilder.RenameColumn(
                name: "AuthorNameNavigationAuthorId",
                table: "Book",
                newName: "AuthorId1");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Book",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_PublisherNameNavigationPublisherId",
                table: "Book",
                newName: "IX_Book_PublisherId1");

            migrationBuilder.RenameIndex(
                name: "IX_Book_AuthorNameNavigationAuthorId",
                table: "Book",
                newName: "IX_Book_AuthorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_AuthorId1",
                table: "Book",
                column: "AuthorId1",
                principalTable: "Author",
                principalColumn: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Publisher_PublisherId1",
                table: "Book",
                column: "PublisherId1",
                principalTable: "Publisher",
                principalColumn: "PublisherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_AuthorId1",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Publisher_PublisherId1",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "PublisherId1",
                table: "Book",
                newName: "PublisherNameNavigationPublisherId");

            migrationBuilder.RenameColumn(
                name: "PublisherId",
                table: "Book",
                newName: "Publisher");

            migrationBuilder.RenameColumn(
                name: "AuthorId1",
                table: "Book",
                newName: "AuthorNameNavigationAuthorId");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Book",
                newName: "Author");

            migrationBuilder.RenameIndex(
                name: "IX_Book_PublisherId1",
                table: "Book",
                newName: "IX_Book_PublisherNameNavigationPublisherId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_AuthorId1",
                table: "Book",
                newName: "IX_Book_AuthorNameNavigationAuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_AuthorNameNavigationAuthorId",
                table: "Book",
                column: "AuthorNameNavigationAuthorId",
                principalTable: "Author",
                principalColumn: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Publisher_PublisherNameNavigationPublisherId",
                table: "Book",
                column: "PublisherNameNavigationPublisherId",
                principalTable: "Publisher",
                principalColumn: "PublisherId");
        }
    }
}
