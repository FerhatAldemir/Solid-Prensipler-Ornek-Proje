using Microsoft.EntityFrameworkCore.Migrations;

namespace Example.DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StLine",
                columns: table => new
                {
                    LogicalRef = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockRef = table.Column<int>(type: "int", nullable: false),
                    InvoiceRef = table.Column<int>(type: "int", nullable: false),
                    StFicheRef = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false)
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
        }
    }
}
