using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektProgramOWanie.Migrations
{
    public partial class admindata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username", "isAdmin" },
                values: new object[] { 1, "$2b$10$VFAkh2nzniG1t3bPFJYMA.1FtzsUEO.Jnt7z3qwhA29Rh3tK4XxO.", "admin", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
