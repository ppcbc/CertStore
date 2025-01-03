using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CertStore.Migrations
{
    /// <inheritdoc />
    public partial class userstaf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserStafs",
                columns: table => new
                {
                    UserStafId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertExamId = table.Column<int>(type: "int", nullable: false),
                    DateOfSelectCertExam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasBought = table.Column<bool>(type: "bit", nullable: false),
                    UserDetailsId = table.Column<int>(type: "int", nullable: false),
                    Redeem = table.Column<bool>(type: "bit", nullable: false),
                    DateOfSendCertExam = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStafs", x => x.UserStafId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserStafs");
        }
    }
}
