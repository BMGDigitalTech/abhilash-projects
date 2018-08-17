using Microsoft.EntityFrameworkCore.Migrations;

namespace forms.Migrations
{
    public partial class validation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Albums",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Albums",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);
        }
    }
}
