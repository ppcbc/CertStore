using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CertStore.Migrations
{
    /// <inheritdoc />
    public partial class testlistffff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_CertExams_CertExamId",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameIndex(
                name: "IX_Item_CertExamId",
                table: "Items",
                newName: "IX_Items_CertExamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "ItemKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_CertExams_CertExamId",
                table: "Items",
                column: "CertExamId",
                principalTable: "CertExams",
                principalColumn: "CertExamId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_CertExams_CertExamId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.RenameIndex(
                name: "IX_Items_CertExamId",
                table: "Item",
                newName: "IX_Item_CertExamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "ItemKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_CertExams_CertExamId",
                table: "Item",
                column: "CertExamId",
                principalTable: "CertExams",
                principalColumn: "CertExamId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
