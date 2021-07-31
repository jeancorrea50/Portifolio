using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portifolio.Migrations
{
    public partial class AgendamentoV03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Motoristas_Veiculos_VeiculoID",
                table: "Motoristas");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaFiscal_Veiculos_VeiculoID",
                table: "NotaFiscal");

            migrationBuilder.DropIndex(
                name: "IX_NotaFiscal_VeiculoID",
                table: "NotaFiscal");

            migrationBuilder.DropIndex(
                name: "IX_Motoristas_VeiculoID",
                table: "Motoristas");

            migrationBuilder.DropColumn(
                name: "VeiculoID",
                table: "NotaFiscal");

            migrationBuilder.DropColumn(
                name: "VeiculoID",
                table: "Motoristas");

            migrationBuilder.AddColumn<Guid>(
                name: "AgendaId",
                table: "Veiculos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotoristaID",
                table: "Veiculos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AgendaId",
                table: "NotaFiscal",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DataNascimentoMot",
                table: "Motoristas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "TelefoneMot",
                table: "Motoristas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataHoraAge = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_AgendaId",
                table: "Veiculos",
                column: "AgendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_MotoristaID",
                table: "Veiculos",
                column: "MotoristaID");

            migrationBuilder.CreateIndex(
                name: "IX_NotaFiscal_AgendaId",
                table: "NotaFiscal",
                column: "AgendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaFiscal_Agenda_AgendaId",
                table: "NotaFiscal",
                column: "AgendaId",
                principalTable: "Agenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculos_Agenda_AgendaId",
                table: "Veiculos",
                column: "AgendaId",
                principalTable: "Agenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculos_Motoristas_MotoristaID",
                table: "Veiculos",
                column: "MotoristaID",
                principalTable: "Motoristas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotaFiscal_Agenda_AgendaId",
                table: "NotaFiscal");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculos_Agenda_AgendaId",
                table: "Veiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculos_Motoristas_MotoristaID",
                table: "Veiculos");

            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropIndex(
                name: "IX_Veiculos_AgendaId",
                table: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_Veiculos_MotoristaID",
                table: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_NotaFiscal_AgendaId",
                table: "NotaFiscal");

            migrationBuilder.DropColumn(
                name: "AgendaId",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "MotoristaID",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "AgendaId",
                table: "NotaFiscal");

            migrationBuilder.DropColumn(
                name: "TelefoneMot",
                table: "Motoristas");

            migrationBuilder.AddColumn<int>(
                name: "VeiculoID",
                table: "NotaFiscal",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimentoMot",
                table: "Motoristas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VeiculoID",
                table: "Motoristas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NotaFiscal_VeiculoID",
                table: "NotaFiscal",
                column: "VeiculoID");

            migrationBuilder.CreateIndex(
                name: "IX_Motoristas_VeiculoID",
                table: "Motoristas",
                column: "VeiculoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Motoristas_Veiculos_VeiculoID",
                table: "Motoristas",
                column: "VeiculoID",
                principalTable: "Veiculos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NotaFiscal_Veiculos_VeiculoID",
                table: "NotaFiscal",
                column: "VeiculoID",
                principalTable: "Veiculos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
