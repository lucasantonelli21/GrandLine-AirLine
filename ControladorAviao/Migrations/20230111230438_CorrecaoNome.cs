using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControladorAviao.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaoNome : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voos_Avioes_aviaoId",
                table: "Voos");

            migrationBuilder.RenameColumn(
                name: "aviaoId",
                table: "Voos",
                newName: "AviaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Voos_aviaoId",
                table: "Voos",
                newName: "IX_Voos_AviaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Voos_Avioes_AviaoId",
                table: "Voos",
                column: "AviaoId",
                principalTable: "Avioes",
                principalColumn: "NumeroRegistro",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voos_Avioes_AviaoId",
                table: "Voos");

            migrationBuilder.RenameColumn(
                name: "AviaoId",
                table: "Voos",
                newName: "aviaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Voos_AviaoId",
                table: "Voos",
                newName: "IX_Voos_aviaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Voos_Avioes_aviaoId",
                table: "Voos",
                column: "aviaoId",
                principalTable: "Avioes",
                principalColumn: "NumeroRegistro",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
