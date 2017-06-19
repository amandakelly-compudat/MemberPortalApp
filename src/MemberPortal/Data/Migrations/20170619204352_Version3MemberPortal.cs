using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MemberPortal.Data.Migrations
{
    public partial class Version3MemberPortal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Members_MemberID",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Pension",
                columns: table => new
                {
                    RemitID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JS50 = table.Column<bool>(nullable: false),
                    JS75 = table.Column<bool>(nullable: false),
                    MemberID = table.Column<int>(nullable: false),
                    PensionType = table.Column<string>(nullable: true),
                    RetirementDate = table.Column<DateTime>(nullable: false),
                    SpouseOption = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pension", x => x.RemitID);
                    table.ForeignKey(
                        name: "FK_Pension_Members_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Members",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AlterColumn<int>(
                name: "MemberID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pension_MemberID",
                table: "Pension",
                column: "MemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Members_MemberID",
                table: "AspNetUsers",
                column: "MemberID",
                principalTable: "Members",
                principalColumn: "MemberID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Members_MemberID",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Pension");

            migrationBuilder.AlterColumn<int>(
                name: "MemberID",
                table: "AspNetUsers",
                nullable: false);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Members_MemberID",
                table: "AspNetUsers",
                column: "MemberID",
                principalTable: "Members",
                principalColumn: "MemberID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
