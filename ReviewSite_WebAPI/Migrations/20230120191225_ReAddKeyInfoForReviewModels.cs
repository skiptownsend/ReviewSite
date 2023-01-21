using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReviewSite_WebAPI.Migrations
{
    public partial class ReAddKeyInfoForReviewModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 12, 12, 25, 481, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 12, 12, 25, 481, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 12, 12, 25, 481, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 12, 12, 25, 481, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 12, 12, 25, 481, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 12, 12, 25, 481, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 12, 12, 25, 481, DateTimeKind.Local).AddTicks(1391));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 11, 45, 39, 862, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 11, 45, 39, 862, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 11, 45, 39, 862, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 11, 45, 39, 862, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 11, 45, 39, 862, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 11, 45, 39, 862, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 11, 45, 39, 862, DateTimeKind.Local).AddTicks(7624));
        }
    }
}
