using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektProgramOWanie.Migrations
{
    public partial class ullnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2b$10$pZr7mrj5nQFuhxZJhHKMEuOAZjCyaKVpvhpDnAfrogqZJs0/CbPma");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2b$10$VFAkh2nzniG1t3bPFJYMA.1FtzsUEO.Jnt7z3qwhA29Rh3tK4XxO.");
        }
    }
}
