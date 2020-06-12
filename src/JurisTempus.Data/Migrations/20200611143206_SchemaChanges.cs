using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JurisTempus.Data.Migrations
{
    public partial class SchemaChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeBills",
                keyColumn: "Id",
                keyValue: 1,
                column: "WorkDate",
                value: new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeBills",
                keyColumn: "Id",
                keyValue: 1,
                column: "WorkDate",
                value: new DateTime(2020, 3, 3, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
