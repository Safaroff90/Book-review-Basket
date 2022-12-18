using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _Pustok.Migrations
{
    public partial class AvgRateAddedIntoBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "AvgRate",
                table: "Books",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvgRate",
                table: "Books");
        }
    }
}
