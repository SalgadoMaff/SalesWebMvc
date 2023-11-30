using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWebMvc.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Seller",
                columns: new[] { "Id", "BaseSalary", "BirthDate", "DepartmentId", "Email", "Name" },
                values: new object[,]
                {
                    { 1, 1000.0, new DateTime(1998, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "bob@gmail.com", "Bob Brown" },
                    { 2, 3500.0, new DateTime(1979, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "maria@gmail.com", "Maria Green" },
                    { 3, 2200.0, new DateTime(1988, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "alex@gmail.com", "Alex Grey" },
                    { 4, 3000.0, new DateTime(1993, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "martha@gmail.com", "Martha Red" },
                    { 5, 4000.0, new DateTime(2000, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "donald@gmail.com", "Donald Blue" },
                    { 6, 3000.0, new DateTime(1997, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "bob@gmail.com", "Alex Pink" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
