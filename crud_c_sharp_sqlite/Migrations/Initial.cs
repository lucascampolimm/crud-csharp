using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace crud_c_sharp_sqlite.Migrations
{
    public partial class Initial : Migration
    {
        // Método que define os parâmetros e informações da tabela e cria ela se não existir.
        // Código auto gerado pelo SQLite.
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    FatherName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    // Define que dentro da tabela vai ter uma primary que é ID.
                    // x aponta dentro da estrutura quem vai ser a primary key.
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }
        
        // Método que dropa a tabela.
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
