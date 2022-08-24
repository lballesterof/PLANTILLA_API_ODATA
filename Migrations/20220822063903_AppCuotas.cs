using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PLANTILLA_API_ODATA.Migrations
{
    public partial class AppCuotas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombreMozo",
                table: "OPE_MESA",
                newName: "NOMBRE_MOZO");

            migrationBuilder.AddColumn<string>(
                name: "APP_CONTRASENA",
                table: "OPE_PERSONA",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CODIGO_ACTIVACION",
                table: "OPE_PERSONA",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FECHA_EXPIRA",
                table: "OPE_PERSONA",
                type: "datetime",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ID_PEDIDO",
                table: "OPE_MESA",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "APP_CONTRASENA",
                table: "OPE_PERSONA");

            migrationBuilder.DropColumn(
                name: "CODIGO_ACTIVACION",
                table: "OPE_PERSONA");

            migrationBuilder.DropColumn(
                name: "FECHA_EXPIRA",
                table: "OPE_PERSONA");

            migrationBuilder.RenameColumn(
                name: "NOMBRE_MOZO",
                table: "OPE_MESA",
                newName: "NombreMozo");

            migrationBuilder.AlterColumn<int>(
                name: "ID_PEDIDO",
                table: "OPE_MESA",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }
    }
}
