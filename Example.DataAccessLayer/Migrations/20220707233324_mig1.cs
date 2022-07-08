using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Example.DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "INVOICE",
                columns: table => new
                {
                    LogicalRef = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DocNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INVOICE", x => x.LogicalRef);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "INVOICE");
        }
    }
}
