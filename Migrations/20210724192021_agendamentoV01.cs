using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portifolio.Migrations
{
    public partial class agendamentoV01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlacaVeic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeloVeic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarcaVeic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapacidadeLiquidaVeic = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Motoristas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCompletoMot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CpfMot = table.Column<int>(type: "int", nullable: false),
                    EmailMot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimentoMot = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VeiculoID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motoristas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Motoristas_Veiculos_VeiculoID",
                        column: x => x.VeiculoID,
                        principalTable: "Veiculos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NotaFiscal",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroNf = table.Column<int>(type: "int", nullable: false),
                    SerieNf = table.Column<int>(type: "int", nullable: false),
                    RemetenteNf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinatarioNf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataEmissaoNf = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorNf = table.Column<double>(type: "float", nullable: false),
                    ProdutoNf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PesoNf = table.Column<double>(type: "float", nullable: false),
                    QuantidadeNf = table.Column<double>(type: "float", nullable: false),
                    VeiculoID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaFiscal", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NotaFiscal_Veiculos_VeiculoID",
                        column: x => x.VeiculoID,
                        principalTable: "Veiculos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Motoristas_VeiculoID",
                table: "Motoristas",
                column: "VeiculoID");

            migrationBuilder.CreateIndex(
                name: "IX_NotaFiscal_VeiculoID",
                table: "NotaFiscal",
                column: "VeiculoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motoristas");

            migrationBuilder.DropTable(
                name: "NotaFiscal");

            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
