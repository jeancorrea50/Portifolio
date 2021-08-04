using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portifolio.Migrations
{
    public partial class V01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agendas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataHoraAgenda = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotasFiscais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroNf = table.Column<int>(type: "int", nullable: false),
                    SerieNf = table.Column<int>(type: "int", nullable: false),
                    RemetenteNf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DestinatarioNf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataEmissaoNf = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorNf = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProdutoNf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PesoNf = table.Column<double>(type: "float", nullable: false),
                    AgendaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotasFiscais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotasFiscais_Agendas_AgendaId",
                        column: x => x.AgendaId,
                        principalTable: "Agendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlacaVeic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlacaCarre1Veic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlacaCarre2Veic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeloVeic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarcaVeic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapacidadeVeic = table.Column<double>(type: "float", nullable: false),
                    NotaFiscalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Veiculos_NotasFiscais_NotaFiscalId",
                        column: x => x.NotaFiscalId,
                        principalTable: "NotasFiscais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Motoristas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCompletoMot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CpfMot = table.Column<int>(type: "int", nullable: false),
                    TelefoneMot = table.Column<int>(type: "int", nullable: false),
                    EmailMot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimentoMot = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VeiculoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motoristas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motoristas_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Motoristas_VeiculoId",
                table: "Motoristas",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasFiscais_AgendaId",
                table: "NotasFiscais",
                column: "AgendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_NotaFiscalId",
                table: "Veiculos",
                column: "NotaFiscalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motoristas");

            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "NotasFiscais");

            migrationBuilder.DropTable(
                name: "Agendas");
        }
    }
}
