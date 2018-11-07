using Microsoft.EntityFrameworkCore.Migrations;

namespace ContextoCore.Migrations
{
    public partial class cambiotablahistoriales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IdUsuario",
                table: "Historiales",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdUsuario",
                table: "Historiales",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
