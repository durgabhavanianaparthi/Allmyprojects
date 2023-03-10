using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneToManyForeignKeyusing.Migrations
{
    /// <inheritdoc />
    public partial class Durgabhavani : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyState",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyState", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "MyCity",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyCity", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_MyCity_MyState_StateId",
                        column: x => x.StateId,
                        principalTable: "MyState",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyCity_StateId",
                table: "MyCity",
                column: "StateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyCity");

            migrationBuilder.DropTable(
                name: "MyState");
        }
    }
}
