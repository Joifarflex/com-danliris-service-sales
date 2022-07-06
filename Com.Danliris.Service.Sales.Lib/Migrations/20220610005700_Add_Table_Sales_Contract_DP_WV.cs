using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Danliris.Service.Sales.Lib.Migrations
{
    public partial class Add_Table_Sales_Contract_DP_WV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BuyerJob",
                table: "WeavingSalesContract",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaterialCode",
                table: "WeavingSalesContract",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaterialID",
                table: "WeavingSalesContract",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MaterialName",
                table: "WeavingSalesContract",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MaterialPrice",
                table: "WeavingSalesContract",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "MaterialTags",
                table: "WeavingSalesContract",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductTypeCode",
                table: "WeavingSalesContract",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductTypeId",
                table: "WeavingSalesContract",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProductTypeName",
                table: "WeavingSalesContract",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BuyerJob",
                table: "SpinningSalesContract",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaterialCode",
                table: "SpinningSalesContract",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaterialConstructionCode",
                table: "SpinningSalesContract",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaterialConstructionId",
                table: "SpinningSalesContract",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MaterialConstructionName",
                table: "SpinningSalesContract",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaterialID",
                table: "SpinningSalesContract",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MaterialName",
                table: "SpinningSalesContract",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MaterialPrice",
                table: "SpinningSalesContract",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "MaterialTags",
                table: "SpinningSalesContract",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductTypeCode",
                table: "SpinningSalesContract",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductTypeId",
                table: "SpinningSalesContract",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProductTypeName",
                table: "SpinningSalesContract",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BuyerJob",
                table: "FinishingPrintingSalesContracts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductTypeCode",
                table: "FinishingPrintingSalesContracts",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductTypeId",
                table: "FinishingPrintingSalesContracts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProductTypeName",
                table: "FinishingPrintingSalesContracts",
                maxLength: 255,
                nullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuyerJob",
                table: "WeavingSalesContract");

            migrationBuilder.DropColumn(
                name: "MaterialCode",
                table: "WeavingSalesContract");

            migrationBuilder.DropColumn(
                name: "MaterialID",
                table: "WeavingSalesContract");

            migrationBuilder.DropColumn(
                name: "MaterialName",
                table: "WeavingSalesContract");

            migrationBuilder.DropColumn(
                name: "MaterialPrice",
                table: "WeavingSalesContract");

            migrationBuilder.DropColumn(
                name: "MaterialTags",
                table: "WeavingSalesContract");

            migrationBuilder.DropColumn(
                name: "ProductTypeCode",
                table: "WeavingSalesContract");

            migrationBuilder.DropColumn(
                name: "ProductTypeId",
                table: "WeavingSalesContract");

            migrationBuilder.DropColumn(
                name: "ProductTypeName",
                table: "WeavingSalesContract");

            migrationBuilder.DropColumn(
                name: "BuyerJob",
                table: "SpinningSalesContract");

            migrationBuilder.DropColumn(
                name: "MaterialCode",
                table: "SpinningSalesContract");

            migrationBuilder.DropColumn(
                name: "MaterialConstructionCode",
                table: "SpinningSalesContract");

            migrationBuilder.DropColumn(
                name: "MaterialConstructionId",
                table: "SpinningSalesContract");

            migrationBuilder.DropColumn(
                name: "MaterialConstructionName",
                table: "SpinningSalesContract");

            migrationBuilder.DropColumn(
                name: "MaterialID",
                table: "SpinningSalesContract");

            migrationBuilder.DropColumn(
                name: "MaterialName",
                table: "SpinningSalesContract");

            migrationBuilder.DropColumn(
                name: "MaterialPrice",
                table: "SpinningSalesContract");

            migrationBuilder.DropColumn(
                name: "MaterialTags",
                table: "SpinningSalesContract");

            migrationBuilder.DropColumn(
                name: "ProductTypeCode",
                table: "SpinningSalesContract");

            migrationBuilder.DropColumn(
                name: "ProductTypeId",
                table: "SpinningSalesContract");

            migrationBuilder.DropColumn(
                name: "ProductTypeName",
                table: "SpinningSalesContract");

            migrationBuilder.DropColumn(
                name: "BuyerJob",
                table: "FinishingPrintingSalesContracts");

            migrationBuilder.DropColumn(
                name: "ProductTypeCode",
                table: "FinishingPrintingSalesContracts");

            migrationBuilder.DropColumn(
                name: "ProductTypeId",
                table: "FinishingPrintingSalesContracts");

            migrationBuilder.DropColumn(
                name: "ProductTypeName",
                table: "FinishingPrintingSalesContracts");

        }
    }
}
