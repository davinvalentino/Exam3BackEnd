using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exam_3.Entities.Migrations
{
    public partial class OpenIddict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "D001",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 25, 910, DateTimeKind.Unspecified).AddTicks(4271), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "D002",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 25, 910, DateTimeKind.Unspecified).AddTicks(4272), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "D003",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 25, 910, DateTimeKind.Unspecified).AddTicks(4273), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "D004",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 25, 910, DateTimeKind.Unspecified).AddTicks(4273), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "F001",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 25, 910, DateTimeKind.Unspecified).AddTicks(4268), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "F002",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 25, 910, DateTimeKind.Unspecified).AddTicks(4269), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "F003",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 25, 910, DateTimeKind.Unspecified).AddTicks(4270), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "F004",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 25, 910, DateTimeKind.Unspecified).AddTicks(4271), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "R001",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 25, 910, DateTimeKind.Unspecified).AddTicks(4263), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "R002",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 25, 910, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "U001",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 25, 910, DateTimeKind.Unspecified).AddTicks(4257), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "U002",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 25, 910, DateTimeKind.Unspecified).AddTicks(4259), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "D001",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 13, 835, DateTimeKind.Unspecified).AddTicks(7238), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "D002",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 13, 835, DateTimeKind.Unspecified).AddTicks(7239), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "D003",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 13, 835, DateTimeKind.Unspecified).AddTicks(7239), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "D004",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 13, 835, DateTimeKind.Unspecified).AddTicks(7240), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "F001",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 13, 835, DateTimeKind.Unspecified).AddTicks(7235), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "F002",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 13, 835, DateTimeKind.Unspecified).AddTicks(7236), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "F003",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 13, 835, DateTimeKind.Unspecified).AddTicks(7237), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "F004",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 13, 835, DateTimeKind.Unspecified).AddTicks(7237), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "R001",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 13, 835, DateTimeKind.Unspecified).AddTicks(7230), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "R002",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 13, 835, DateTimeKind.Unspecified).AddTicks(7231), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "U001",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 13, 835, DateTimeKind.Unspecified).AddTicks(7226), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "U002",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 38, 13, 835, DateTimeKind.Unspecified).AddTicks(7228), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
