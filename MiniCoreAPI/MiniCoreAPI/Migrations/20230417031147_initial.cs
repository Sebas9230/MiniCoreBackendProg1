using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinicoreCompras.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    idCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCliente = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__clientes__885457EE3102FCF7", x => x.idCliente);
                });

            migrationBuilder.CreateTable(
                name: "Contratos",
                columns: table => new
                {
                    idContrato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idCliente = table.Column<int>(type: "int", nullable: false),
                    contratos = table.Column<string>(type: "varchar(900)", unicode: false, maxLength: 900, nullable: false),
                    Monto = table.Column<int>(type: "int", nullable: false),
                    fechaContrato = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Contrato__91431FE1C0001ED1", x => x.idContrato);
                    table.ForeignKey(
                        name: "FK_PersonOrder",
                        column: x => x.idCliente,
                        principalTable: "clientes",
                        principalColumn: "idCliente");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_idCliente",
                table: "Contratos",
                column: "idCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contratos");

            migrationBuilder.DropTable(
                name: "clientes");
        }
    }
}
