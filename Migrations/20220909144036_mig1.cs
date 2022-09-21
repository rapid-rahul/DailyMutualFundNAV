using Microsoft.EntityFrameworkCore.Migrations;

namespace DailyMutualFundNAV.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyMutualFundDetails",
                columns: table => new
                {
                    MutualFundId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MutualFundName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MutualFundvalue = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyMutualFundDetails", x => x.MutualFundId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyMutualFundDetails");
        }
    }
}
