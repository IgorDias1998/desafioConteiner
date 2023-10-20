using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioConteiner.Migrations
{
    /// <inheritdoc />
    public partial class CriarConteinerAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conteiners",
                columns: table => new
                {
                    IdConteiner = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroConteiner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoConteiner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoCategoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conteiners", x => x.IdConteiner);
                });

            migrationBuilder.CreateTable(
                name: "Movimentacaos",
                columns: table => new
                {
                    IdMovimentacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataHoraInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoMovimentacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdConteiner = table.Column<int>(type: "int", nullable: false),
                    ConteinerIdConteiner = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimentacaos", x => x.IdMovimentacao);
                    table.ForeignKey(
                        name: "FK_Movimentacaos_Conteiners_ConteinerIdConteiner",
                        column: x => x.ConteinerIdConteiner,
                        principalTable: "Conteiners",
                        principalColumn: "IdConteiner");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacaos_ConteinerIdConteiner",
                table: "Movimentacaos",
                column: "ConteinerIdConteiner");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movimentacaos");

            migrationBuilder.DropTable(
                name: "Conteiners");
        }
    }
}
