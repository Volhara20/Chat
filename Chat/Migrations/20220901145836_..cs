using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chat.Migrations
{
    public partial class _ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Created", "GroupName", "Updated" },
                values: new object[,]
                {
                    { new Guid("33e26927-34e7-412b-9d11-b0f93a533bb6"), new DateTime(2022, 9, 1, 17, 47, 50, 0, DateTimeKind.Unspecified), "TestGroup1", null },
                    { new Guid("56775ee9-6735-485e-9283-c9ab65831c64"), new DateTime(2022, 9, 1, 17, 48, 50, 0, DateTimeKind.Unspecified), "TestGroup2", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Updated", "UserName" },
                values: new object[,]
                {
                    { new Guid("7aaab85f-fd13-4ea3-bda6-6397100ae230"), new DateTime(2022, 9, 1, 17, 45, 50, 0, DateTimeKind.Unspecified), null, "olka" },
                    { new Guid("d0845b19-dd1f-4459-9890-47e341e5fd15"), new DateTime(2022, 9, 1, 17, 46, 50, 0, DateTimeKind.Unspecified), null, "test" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
