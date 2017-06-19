using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MemberPortal.Data.Migrations
{
    public partial class AddMemberClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Employer = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Local = table.Column<string>(nullable: true),
                    Medical = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    ProfileImage = table.Column<string>(nullable: true),
                    Retired = table.Column<DateTime>(nullable: false),
                    Ssn = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberID);
                });

            migrationBuilder.AddColumn<int>(
                name: "MemberID",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_MemberID",
                table: "AspNetUsers",
                column: "MemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Members_MemberID",
                table: "AspNetUsers",
                column: "MemberID",
                principalTable: "Members",
                principalColumn: "MemberID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Members_MemberID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_MemberID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MemberID",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
