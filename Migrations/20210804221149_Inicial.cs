using Microsoft.EntityFrameworkCore.Migrations;

namespace DinoMatchGame.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MatchDino",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Jugador = table.Column<string>(type: "TEXT", nullable: true),
                    ModoDeJuego = table.Column<string>(type: "TEXT", nullable: true),
                    Dificultad = table.Column<string>(type: "TEXT", nullable: true),
                    TiempoJugada = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchDino", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreCompleto = table.Column<string>(type: "TEXT", nullable: true),
                    NombreDeUsuario = table.Column<string>(type: "TEXT", nullable: true),
                    MejorPuntuación = table.Column<string>(type: "TEXT", nullable: true),
                    VecesJugado = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.UsuarioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchDino");

            migrationBuilder.DropTable(
                name: "usuarios");
        }
    }
}
