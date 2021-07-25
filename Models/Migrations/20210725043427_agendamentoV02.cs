using Microsoft.EntityFrameworkCore.Migrations;

namespace Portifolio.Migrations
{
    public partial class agendamentoV02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantidadeNf",
                table: "NotaFiscal");

            migrationBuilder.RenameColumn(
                name: "CapacidadeLiquidaVeic",
                table: "Veiculos",
                newName: "CapacidadeVeic");

            migrationBuilder.AlterColumn<string>(
                name: "PlacaVeic",
                table: "Veiculos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModeloVeic",
                table: "Veiculos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MarcaVeic",
                table: "Veiculos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlacaCarre1Veic",
                table: "Veiculos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PlacaCarre2Veic",
                table: "Veiculos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorNf",
                table: "NotaFiscal",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "RemetenteNf",
                table: "NotaFiscal",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProdutoNf",
                table: "NotaFiscal",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DestinatarioNf",
                table: "NotaFiscal",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotoristaID",
                table: "NotaFiscal",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeCompletoMot",
                table: "Motoristas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailMot",
                table: "Motoristas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NotaFiscal_MotoristaID",
                table: "NotaFiscal",
                column: "MotoristaID");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaFiscal_Motoristas_MotoristaID",
                table: "NotaFiscal",
                column: "MotoristaID",
                principalTable: "Motoristas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotaFiscal_Motoristas_MotoristaID",
                table: "NotaFiscal");

            migrationBuilder.DropIndex(
                name: "IX_NotaFiscal_MotoristaID",
                table: "NotaFiscal");

            migrationBuilder.DropColumn(
                name: "PlacaCarre1Veic",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "PlacaCarre2Veic",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "MotoristaID",
                table: "NotaFiscal");

            migrationBuilder.RenameColumn(
                name: "CapacidadeVeic",
                table: "Veiculos",
                newName: "CapacidadeLiquidaVeic");

            migrationBuilder.AlterColumn<string>(
                name: "PlacaVeic",
                table: "Veiculos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ModeloVeic",
                table: "Veiculos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MarcaVeic",
                table: "Veiculos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<double>(
                name: "ValorNf",
                table: "NotaFiscal",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "RemetenteNf",
                table: "NotaFiscal",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ProdutoNf",
                table: "NotaFiscal",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DestinatarioNf",
                table: "NotaFiscal",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<double>(
                name: "QuantidadeNf",
                table: "NotaFiscal",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<string>(
                name: "NomeCompletoMot",
                table: "Motoristas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EmailMot",
                table: "Motoristas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
