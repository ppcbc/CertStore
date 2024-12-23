using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CertStore.Migrations
{
    /// <inheritdoc />
    public partial class addexamcategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ExamName",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ExamCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exams_CategoryId",
                table: "Exams",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_ExamCategories_CategoryId",
                table: "Exams",
                column: "CategoryId",
                principalTable: "ExamCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_ExamCategories_CategoryId",
                table: "Exams");

            migrationBuilder.DropTable(
                name: "ExamCategories");

            migrationBuilder.DropIndex(
                name: "IX_Exams_CategoryId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "ExamName",
                table: "Exams");
        }
    }
}
