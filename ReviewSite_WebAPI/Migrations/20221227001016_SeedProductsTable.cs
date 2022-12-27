using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReviewSite_WebAPI.Migrations
{
    public partial class SeedProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 26, 17, 10, 16, 763, DateTimeKind.Local).AddTicks(9767), "Lorem ipsum dolor sit amet.", "./Images/white_t-shirt.jpg", "White T-Shirt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2022, 12, 26, 17, 10, 16, 763, DateTimeKind.Local).AddTicks(9795), "Lorem ipsum dolor sit amet.", "./Images/black_t-shirt.jpg", "Black T-Shirt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2022, 12, 26, 17, 10, 16, 763, DateTimeKind.Local).AddTicks(9798), "Lorem ipsum dolor sit amet.", "./Images/red_t-shirt.jpg", "Red T-Shirt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2022, 12, 26, 17, 10, 16, 763, DateTimeKind.Local).AddTicks(9799), "Lorem ipsum dolor sit amet.", "./Images/blue_t-shirt.jpg", "Blue T-Shirt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2022, 12, 26, 17, 10, 16, 763, DateTimeKind.Local).AddTicks(9801), "Lorem ipsum dolor sit amet.", "./Images/maroon_t-shirt.jpg", "Maroon T-Shirt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2022, 12, 26, 17, 10, 16, 763, DateTimeKind.Local).AddTicks(9803), "Lorem ipsum dolor sit amet.", "./Images/yellow_t-shirt.jpg", "Yellow T-Shirt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
