using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Danliris.Service.Sales.Lib.Migrations
{
    public partial class AddApprovalCCROOnGCC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApprovalCC",
                table: "CostCalculationGarments",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApprovalRO",
                table: "CostCalculationGarments",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovalCC",
                table: "CostCalculationGarments");

            migrationBuilder.DropColumn(
                name: "ApprovalRO",
                table: "CostCalculationGarments");
        }
    }
}
