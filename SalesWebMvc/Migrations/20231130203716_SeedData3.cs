using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWebMvc.Migrations
{
    public partial class SeedData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SalesRecord",
                columns: new[] { "Id", "Amount", "Date", "SellerId", "Status" },
                values: new object[,]
                {
                    { 1, 11000.0, new DateTime(2018, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, 7000.0, new DateTime(2018, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 3, 4000.0, new DateTime(2018, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 4, 8000.0, new DateTime(2018, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 5, 3000.0, new DateTime(2018, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 6, 2000.0, new DateTime(2018, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 7, 13000.0, new DateTime(2018, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 8, 4000.0, new DateTime(2018, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 9, 11000.0, new DateTime(2018, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 0 },
                    { 10, 9000.0, new DateTime(2018, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 11, 6000.0, new DateTime(2018, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 12, 7000.0, new DateTime(2018, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 0 },
                    { 13, 10000.0, new DateTime(2018, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 14, 3000.0, new DateTime(2018, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 15, 4000.0, new DateTime(2018, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 16, 2000.0, new DateTime(2018, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 17, 12000.0, new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 18, 6000.0, new DateTime(2018, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 19, 8000.0, new DateTime(2018, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 20, 8000.0, new DateTime(2018, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 21, 9000.0, new DateTime(2018, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 22, 4000.0, new DateTime(2018, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 23, 11000.0, new DateTime(2018, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 24, 8000.0, new DateTime(2018, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 25, 7000.0, new DateTime(2018, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 26, 5000.0, new DateTime(2018, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 27, 9000.0, new DateTime(2018, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0 },
                    { 28, 4000.0, new DateTime(2018, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 29, 12000.0, new DateTime(2018, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 30, 5000.0, new DateTime(2018, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
