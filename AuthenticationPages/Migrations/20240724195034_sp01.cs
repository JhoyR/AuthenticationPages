using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthenticationPages.Migrations
{
    /// <inheritdoc />
    public partial class sp01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2ffe4e95-231e-4afd-b959-b4288e2c8fd8", null, "manager", "manager" },
                    { "a2afd801-400f-4028-bad2-adf297958952", null, "agent", "agent" },
                    { "ac5e9f9d-2046-469d-9d86-3d5a5b8900bc", null, "admin", "admin" },
                    { "d3196fd0-57e1-4215-ba3e-21a67403a7b3", null, "viewer", "viewer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ffe4e95-231e-4afd-b959-b4288e2c8fd8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2afd801-400f-4028-bad2-adf297958952");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac5e9f9d-2046-469d-9d86-3d5a5b8900bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3196fd0-57e1-4215-ba3e-21a67403a7b3");
        }
    }
}
