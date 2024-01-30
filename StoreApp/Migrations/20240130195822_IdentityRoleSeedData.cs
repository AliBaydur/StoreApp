using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Migrations
{
    public partial class IdentityRoleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d05ba53-e5cf-455f-86de-a7a61e2c57b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77e3b5db-1372-450c-a55c-6e1135a1945d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d95141d3-29a7-4265-8eb2-ab218d753b55");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "63306083-7263-4086-afdb-2b1cf501f83d", "bb083b89-8cfe-41fb-9e19-ce64e4847628", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8aba1bb1-df23-419c-b9ef-8c17ed7f6270", "4ba59399-fadc-4555-8c93-b7a4df4c3d38", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9440ed75-630d-4c82-a1bf-91dba51bdf9d", "c3c13839-a9d1-4a4a-8bdd-3b123b7ba71a", "Editor", "EDITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63306083-7263-4086-afdb-2b1cf501f83d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8aba1bb1-df23-419c-b9ef-8c17ed7f6270");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9440ed75-630d-4c82-a1bf-91dba51bdf9d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d05ba53-e5cf-455f-86de-a7a61e2c57b1", "57c412a9-6190-4805-9cea-a0e819662eed", "Editor,", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "77e3b5db-1372-450c-a55c-6e1135a1945d", "c2021f3f-88b7-4d06-bed0-28b41b46fbb8", "Admin,", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d95141d3-29a7-4265-8eb2-ab218d753b55", "b1659c70-356c-4cf0-adee-3fbc2c073d6f", "User,", "USER" });
        }
    }
}
