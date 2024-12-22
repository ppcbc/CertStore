using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CertStore.Migrations
{
    /// <inheritdoc />
    public partial class Addexam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionPhotoLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Option1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect1 = table.Column<bool>(type: "bit", nullable: false),
                    Option2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect2 = table.Column<bool>(type: "bit", nullable: false),
                    Option3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect3 = table.Column<bool>(type: "bit", nullable: false),
                    Option4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect4 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.ExamId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exams");
        }
    }
}
