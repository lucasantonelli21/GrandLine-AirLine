using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControladorAviao.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Avioes",
                columns: table => new
                {
                    NumeroRegistro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    QntdAssentos = table.Column<int>(type: "int", nullable: false),
                    QntdEspeciais = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avioes", x => x.NumeroRegistro);
                });

            migrationBuilder.CreateTable(
                name: "Voos",
                columns: table => new
                {
                    NumeroVoo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Horario = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    LocalPartida = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LocalChegada = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    ValorNormal = table.Column<float>(type: "real", nullable: false),
                    ValorEspecial = table.Column<float>(type: "real", nullable: false),
                    aviaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voos", x => x.NumeroVoo);
                    table.ForeignKey(
                        name: "FK_Voos_Avioes_aviaoId",
                        column: x => x.aviaoId,
                        principalTable: "Avioes",
                        principalColumn: "NumeroRegistro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Voos_aviaoId",
                table: "Voos",
                column: "aviaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Voos");

            migrationBuilder.DropTable(
                name: "Avioes");
        }
    }
}
