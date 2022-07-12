using Microsoft.EntityFrameworkCore.Migrations;

namespace Example.DataAccessLayer.Migrations.SqlLite
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "StLine",
                columns: table => new
                {
                    LogicalRef = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StockRef = table.Column<int>(type: "INTEGER", nullable: false),
                    InvoiceRef = table.Column<int>(type: "INTEGER", nullable: false),
                    StFicheRef = table.Column<int>(type: "INTEGER", nullable: false),
                    Amount = table.Column<double>(type: "REAL", nullable: false),
                    price = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StLine", x => x.LogicalRef);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_INVOICE",
                table: "INVOICE");

            migrationBuilder.RenameTable(
                name: "INVOICE",
                newName: "Invoice");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice",
                column: "LogicalRef");
        }
    }
}
