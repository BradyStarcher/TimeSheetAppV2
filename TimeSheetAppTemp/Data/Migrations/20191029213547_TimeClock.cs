using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheetAppTemp.Data.Migrations
{
    public partial class TimeClock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payroll",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Salary = table.Column<decimal>(nullable: false),
                    EmployeeIDId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payroll", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Payroll_AspNetUsers_EmployeeIDId",
                        column: x => x.EmployeeIDId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TimeClock",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClockIn = table.Column<DateTime>(nullable: false),
                    InLunch = table.Column<DateTime>(nullable: false),
                    OutLunch = table.Column<DateTime>(nullable: false),
                    ClockOut = table.Column<DateTime>(nullable: false),
                    EmployeeIDId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeClock", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TimeClock_AspNetUsers_EmployeeIDId",
                        column: x => x.EmployeeIDId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payroll_EmployeeIDId",
                table: "Payroll",
                column: "EmployeeIDId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeClock_EmployeeIDId",
                table: "TimeClock",
                column: "EmployeeIDId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payroll");

            migrationBuilder.DropTable(
                name: "TimeClock");
        }
    }
}
