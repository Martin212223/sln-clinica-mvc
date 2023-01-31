using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCClinica.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Medico",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "IdMedico",
                table: "Medico");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Medico",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medico",
                table: "Medico",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Medico",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Medico");

            migrationBuilder.AddColumn<int>(
                name: "IdMedico",
                table: "Medico",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medico",
                table: "Medico",
                column: "IdMedico");
        }
    }
}
