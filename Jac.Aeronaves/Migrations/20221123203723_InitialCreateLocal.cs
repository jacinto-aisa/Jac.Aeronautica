using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jac.Aeronaves.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateLocal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aeronaves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncrementoSueldo = table.Column<float>(type: "real", nullable: false),
                    MesesDesdeMantenimento = table.Column<int>(type: "int", nullable: false),
                    NumeroMotores = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aeronaves", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aeronaves");
        }
    }
}
