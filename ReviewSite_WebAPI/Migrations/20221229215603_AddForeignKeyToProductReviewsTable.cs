using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReviewSite_WebAPI.Migrations
{
    public partial class AddForeignKeyToProductReviewsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "ProductReviews");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductReviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductId" },
                values: new object[] { new DateTime(2022, 12, 29, 14, 56, 2, 981, DateTimeKind.Local).AddTicks(3024), 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 14, 56, 2, 981, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 14, 56, 2, 981, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 14, 56, 2, 981, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 14, 56, 2, 981, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 14, 56, 2, 981, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 14, 56, 2, 981, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_ProductId",
                table: "ProductReviews",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviews_Products_ProductId",
                table: "ProductReviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviews_Products_ProductId",
                table: "ProductReviews");

            migrationBuilder.DropIndex(
                name: "IX_ProductReviews_ProductId",
                table: "ProductReviews");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductReviews");

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
    }
}
