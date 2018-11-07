using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NETExample.Migrations
{
    public partial class ReleaseYearConvertToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ReleaseYear",
                table: "Movies",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReleaseYear",
                table: "Movies",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
