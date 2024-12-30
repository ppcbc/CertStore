using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CertStore.Migrations
{
    /// <inheritdoc />
    public partial class testlist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_CertExams_CertExamId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "FullId",
                table: "Item");

            migrationBuilder.AlterColumn<int>(
                name: "CertExamId",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_CertExams_CertExamId",
                table: "Item",
                column: "CertExamId",
                principalTable: "CertExams",
                principalColumn: "CertExamId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_CertExams_CertExamId",
                table: "Item");

            migrationBuilder.AlterColumn<int>(
                name: "CertExamId",
                table: "Item",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "FullId",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_CertExams_CertExamId",
                table: "Item",
                column: "CertExamId",
                principalTable: "CertExams",
                principalColumn: "CertExamId");
        }
    }
}
