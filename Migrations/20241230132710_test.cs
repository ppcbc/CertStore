using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CertStore.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "CertExams");

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullId = table.Column<int>(type: "int", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    CertExamId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemKey);
                    table.ForeignKey(
                        name: "FK_Item_CertExams_CertExamId",
                        column: x => x.CertExamId,
                        principalTable: "CertExams",
                        principalColumn: "CertExamId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_CertExamId",
                table: "Item",
                column: "CertExamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.AddColumn<int>(
                name: "ExamId",
                table: "CertExams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
