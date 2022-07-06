using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Danliris.Service.Sales.Lib.Migrations
{
    public partial class add_column_table_sc_DP_WV_SP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Claim",
                table: "WeavingSalesContract",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "WeavingSalesContract",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DownPayments",
                table: "WeavingSalesContract",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LatePayment",
                table: "WeavingSalesContract",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LateReturn",
                table: "WeavingSalesContract",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethods",
                table: "WeavingSalesContract",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PriceDP",
                table: "WeavingSalesContract",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "precentageDP",
                table: "WeavingSalesContract",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Claim",
                table: "SpinningSalesContract",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "SpinningSalesContract",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DownPayments",
                table: "SpinningSalesContract",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LatePayment",
                table: "SpinningSalesContract",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LateReturn",
                table: "SpinningSalesContract",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethods",
                table: "SpinningSalesContract",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PriceDP",
                table: "SpinningSalesContract",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "precentageDP",
                table: "SpinningSalesContract",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Claim",
                table: "FinishingPrintingSalesContracts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "FinishingPrintingSalesContracts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DownPayments",
                table: "FinishingPrintingSalesContracts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LatePayment",
                table: "FinishingPrintingSalesContracts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LateReturn",
                table: "FinishingPrintingSalesContracts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethods",
                table: "FinishingPrintingSalesContracts",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PriceDP",
                table: "FinishingPrintingSalesContracts",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "precentageDP",
                table: "FinishingPrintingSalesContracts",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Claim",
                table: "WeavingSalesContract");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "WeavingSalesContract");

            migrationBuilder.DropColumn(
                name: "DownPayments",
                table: "WeavingSalesContract");

            migrationBuilder.DropColumn(
                name: "LatePayment",
                table: "WeavingSalesContract");

            migrationBuilder.DropColumn(
                name: "LateReturn",
                table: "WeavingSalesContract");

            migrationBuilder.DropColumn(
                name: "PaymentMethods",
                table: "WeavingSalesContract");

            migrationBuilder.DropColumn(
                name: "PriceDP",
                table: "WeavingSalesContract");

            migrationBuilder.DropColumn(
                name: "precentageDP",
                table: "WeavingSalesContract");

            migrationBuilder.DropColumn(
                name: "Claim",
                table: "SpinningSalesContract");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "SpinningSalesContract");

            migrationBuilder.DropColumn(
                name: "DownPayments",
                table: "SpinningSalesContract");

            migrationBuilder.DropColumn(
                name: "LatePayment",
                table: "SpinningSalesContract");

            migrationBuilder.DropColumn(
                name: "LateReturn",
                table: "SpinningSalesContract");

            migrationBuilder.DropColumn(
                name: "PaymentMethods",
                table: "SpinningSalesContract");

            migrationBuilder.DropColumn(
                name: "PriceDP",
                table: "SpinningSalesContract");

            migrationBuilder.DropColumn(
                name: "precentageDP",
                table: "SpinningSalesContract");

            migrationBuilder.DropColumn(
                name: "Claim",
                table: "FinishingPrintingSalesContracts");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "FinishingPrintingSalesContracts");

            migrationBuilder.DropColumn(
                name: "DownPayments",
                table: "FinishingPrintingSalesContracts");

            migrationBuilder.DropColumn(
                name: "LatePayment",
                table: "FinishingPrintingSalesContracts");

            migrationBuilder.DropColumn(
                name: "LateReturn",
                table: "FinishingPrintingSalesContracts");

            migrationBuilder.DropColumn(
                name: "PaymentMethods",
                table: "FinishingPrintingSalesContracts");

            migrationBuilder.DropColumn(
                name: "PriceDP",
                table: "FinishingPrintingSalesContracts");

            migrationBuilder.DropColumn(
                name: "precentageDP",
                table: "FinishingPrintingSalesContracts");
        }
    }
}
