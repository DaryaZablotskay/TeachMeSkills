using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HW_17._12.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "SupportSpecialists",
                columns: table => new
                {
                    SupportSpecialistId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 1000, nullable: true),
                    DepartmentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportSpecialists", x => x.SupportSpecialistId);
                    table.ForeignKey(
                        name: "FK_SupportSpecialists_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupportRequests",
                columns: table => new
                {
                    SupportRequestId = table.Column<Guid>(nullable: false),
                    Topic = table.Column<string>(maxLength: 1000, nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    Status = table.Column<string>(maxLength: 1000, nullable: true),
                    SupportSpecialistId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportRequests", x => x.SupportRequestId);
                    table.ForeignKey(
                        name: "FK_SupportRequests_SupportSpecialists_SupportSpecialistId",
                        column: x => x.SupportSpecialistId,
                        principalTable: "SupportSpecialists",
                        principalColumn: "SupportSpecialistId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupportRequests_SupportSpecialistId",
                table: "SupportRequests",
                column: "SupportSpecialistId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportSpecialists_DepartmentId",
                table: "SupportSpecialists",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupportRequests");

            migrationBuilder.DropTable(
                name: "SupportSpecialists");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
