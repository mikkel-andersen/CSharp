using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ejer",
                columns: table => new
                {
                    EjerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    navn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ejer", x => x.EjerID);
                });

            migrationBuilder.CreateTable(
                name: "Bil",
                columns: table => new
                {
                    BilID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    EjerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bil", x => x.BilID);
                    table.ForeignKey(
                        name: "FK_Bil_Ejer_EjerID",
                        column: x => x.EjerID,
                        principalTable: "Ejer",
                        principalColumn: "EjerID");
                });

            migrationBuilder.InsertData(
                table: "Bil",
                columns: new[] { "BilID", "EjerID", "Name", "Weight" },
                values: new object[] { 1, null, "BMW", 1400 });

            migrationBuilder.CreateIndex(
                name: "IX_Bil_EjerID",
                table: "Bil",
                column: "EjerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bil");

            migrationBuilder.DropTable(
                name: "Ejer");
        }
    }
}
