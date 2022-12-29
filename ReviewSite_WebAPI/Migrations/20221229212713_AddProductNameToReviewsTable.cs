using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReviewSite_WebAPI.Migrations
{
    public partial class AddProductNameToReviewsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "ProductReviews",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductName" },
                values: new object[] { new DateTime(2022, 12, 29, 14, 27, 13, 256, DateTimeKind.Local).AddTicks(5891), "Black T-Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 14, 27, 13, 256, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 14, 27, 13, 256, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 14, 27, 13, 256, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 14, 27, 13, 256, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 14, 27, 13, 256, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 14, 27, 13, 256, DateTimeKind.Local).AddTicks(5812));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "ProductReviews");

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 13, 17, 42, 834, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 13, 17, 42, 834, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 13, 17, 42, 834, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 13, 17, 42, 834, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 13, 17, 42, 834, DateTimeKind.Local).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 13, 17, 42, 834, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 13, 17, 42, 834, DateTimeKind.Local).AddTicks(5823));
        }
    }
}
