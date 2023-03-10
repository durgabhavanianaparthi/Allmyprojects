using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class StateAndCitys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StateTable",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateCM = table.Column<string>(name: "State_CM", type: "nvarchar(max)", nullable: true),
                    TotalStatePopulation = table.Column<long>(type: "bigint", nullable: true),
                    TollFreeNumber = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateTable", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "CityTable",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalCityPopulation = table.Column<int>(type: "int", nullable: true),
                    LiteracyRate = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityTable", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_CityTable_StateTable_StateId",
                        column: x => x.StateId,
                        principalTable: "StateTable",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CityTable_StateId",
                table: "CityTable",
                column: "StateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityTable");

            migrationBuilder.DropTable(
                name: "StateTable");
        }
    }
}
