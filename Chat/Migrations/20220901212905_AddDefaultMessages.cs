using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chat.Migrations
{
    public partial class AddDefaultMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Created", "FromUserId", "GroupId", "IsVisible", "IsVisibleForOwner", "ReplyMessageId", "Text", "ToUserId", "Updated" },
                values: new object[,]
                {
                    { new Guid("315a053f-f19a-4a5d-9022-e6190400c006"), new DateTime(2022, 9, 1, 17, 57, 50, 0, DateTimeKind.Unspecified), new Guid("7aaab85f-fd13-4ea3-bda6-6397100ae230"), new Guid("33e26927-34e7-412b-9d11-b0f93a533bb6"), true, true, null, "Kek", null, null },
                    { new Guid("5d045d62-5364-4aa1-b12a-2eab889d6a77"), new DateTime(2022, 9, 1, 17, 56, 50, 0, DateTimeKind.Unspecified), new Guid("d0845b19-dd1f-4459-9890-47e341e5fd15"), null, true, true, null, "Hi", new Guid("7aaab85f-fd13-4ea3-bda6-6397100ae230"), null },
                    { new Guid("9f822d7d-dd51-40be-af82-115916947844"), new DateTime(2022, 9, 1, 17, 55, 50, 0, DateTimeKind.Unspecified), new Guid("7aaab85f-fd13-4ea3-bda6-6397100ae230"), null, true, true, null, "Hello", new Guid("d0845b19-dd1f-4459-9890-47e341e5fd15"), null },
                    { new Guid("d59b98a3-2fc7-48af-a483-07b6f0d45c6c"), new DateTime(2022, 9, 1, 17, 56, 50, 0, DateTimeKind.Unspecified), new Guid("d0845b19-dd1f-4459-9890-47e341e5fd15"), new Guid("33e26927-34e7-412b-9d11-b0f93a533bb6"), true, true, null, "Lol", null, null }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Created", "FromUserId", "GroupId", "IsVisible", "IsVisibleForOwner", "ReplyMessageId", "Text", "ToUserId", "Updated" },
                values: new object[] { new Guid("7f00d977-9b3a-4780-896d-1fb4d3d6ecae"), new DateTime(2022, 9, 1, 17, 57, 50, 0, DateTimeKind.Unspecified), new Guid("7aaab85f-fd13-4ea3-bda6-6397100ae230"), null, true, true, new Guid("5d045d62-5364-4aa1-b12a-2eab889d6a77"), "How are you?", new Guid("d0845b19-dd1f-4459-9890-47e341e5fd15"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("315a053f-f19a-4a5d-9022-e6190400c006"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7f00d977-9b3a-4780-896d-1fb4d3d6ecae"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9f822d7d-dd51-40be-af82-115916947844"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d59b98a3-2fc7-48af-a483-07b6f0d45c6c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5d045d62-5364-4aa1-b12a-2eab889d6a77"));
        }
    }
}
