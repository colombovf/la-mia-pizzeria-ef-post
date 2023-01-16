using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaMiaPizzeria.Migrations
{
    /// <inheritdoc />
    public partial class CambioDatiTypeVarChar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "Pizze",
                type: "varchar(300)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Pizze",
                type: "varchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "Pizze",
                type: "varchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Pizze",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)");
        }
    }
}
