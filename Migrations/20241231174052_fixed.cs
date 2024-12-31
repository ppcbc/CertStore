using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CertStore.Migrations
{
    /// <inheritdoc />
    public partial class @fixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "CertExams");

            migrationBuilder.RenameColumn(
                name: "ExamId",
                table: "Items",
                newName: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Items",
                newName: "ExamId");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "CertExams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
