using Microsoft.EntityFrameworkCore.Migrations;

namespace practica_dos.Migrations
{
    public partial class ModifSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Amigos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Ciudad",
                value: 7);

            migrationBuilder.InsertData(
                table: "Amigos",
                columns: new[] { "Id", "Ciudad", "Email", "Nombre" },
                values: new object[] { 3, 4, "Tercero@mail.com", "Tercero" });

            migrationBuilder.InsertData(
                table: "Amigos",
                columns: new[] { "Id", "Ciudad", "Email", "Nombre" },
                values: new object[] { 2, 1, "segundo@mail.com", "Segundo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amigos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amigos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Amigos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Ciudad",
                value: 1);
        }
    }
}
