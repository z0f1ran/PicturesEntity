using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp5.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author_p",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearOfBorn = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author_p", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Picture_p",
                columns: table => new
                {
                    Id_p = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_p = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year_p = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picture_p", x => x.Id_p);
                    table.ForeignKey(
                        name: "FK_Picture_p_Author_p_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author_p",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Picture_p_AuthorId",
                table: "Picture_p",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Picture_p");

            migrationBuilder.DropTable(
                name: "Author_p");
        }
    }
}
