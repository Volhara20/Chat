using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chat.Migrations
{
    public partial class AddUsersGroupData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserGroupsRelationship",
                columns: new[] { "GroupsId", "UsersId" },
                values: new object[] { new Guid("33e26927-34e7-412b-9d11-b0f93a533bb6"), new Guid("7aaab85f-fd13-4ea3-bda6-6397100ae230") });

            migrationBuilder.InsertData(
                table: "UserGroupsRelationship",
                columns: new[] { "GroupsId", "UsersId" },
                values: new object[] { new Guid("33e26927-34e7-412b-9d11-b0f93a533bb6"), new Guid("d0845b19-dd1f-4459-9890-47e341e5fd15") });

            migrationBuilder.InsertData(
                table: "UserGroupsRelationship",
                columns: new[] { "GroupsId", "UsersId" },
                values: new object[] { new Guid("56775ee9-6735-485e-9283-c9ab65831c64"), new Guid("7aaab85f-fd13-4ea3-bda6-6397100ae230") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserGroupsRelationship",
                keyColumns: new[] { "GroupsId", "UsersId" },
                keyValues: new object[] { new Guid("33e26927-34e7-412b-9d11-b0f93a533bb6"), new Guid("7aaab85f-fd13-4ea3-bda6-6397100ae230") });

            migrationBuilder.DeleteData(
                table: "UserGroupsRelationship",
                keyColumns: new[] { "GroupsId", "UsersId" },
                keyValues: new object[] { new Guid("33e26927-34e7-412b-9d11-b0f93a533bb6"), new Guid("d0845b19-dd1f-4459-9890-47e341e5fd15") });

            migrationBuilder.DeleteData(
                table: "UserGroupsRelationship",
                keyColumns: new[] { "GroupsId", "UsersId" },
                keyValues: new object[] { new Guid("56775ee9-6735-485e-9283-c9ab65831c64"), new Guid("7aaab85f-fd13-4ea3-bda6-6397100ae230") });
        }
    }
}
