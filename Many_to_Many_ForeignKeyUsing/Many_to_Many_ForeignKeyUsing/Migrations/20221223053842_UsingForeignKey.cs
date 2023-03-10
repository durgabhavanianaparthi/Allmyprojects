using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManytoManyForeignKeyUsing.Migrations
{
    /// <inheritdoc />
    public partial class UsingForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerAge = table.Column<int>(type: "int", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "CustomersProducts",
                columns: table => new
                {
                    CustomerProductId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersProducts", x => x.CustomerProductId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    productPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerCustomerProduct",
                columns: table => new
                {
                    CustomerProductsCustomerProductId = table.Column<long>(type: "bigint", nullable: false),
                    CustomersPropertiesCustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCustomerProduct", x => new { x.CustomerProductsCustomerProductId, x.CustomersPropertiesCustomerId });
                    table.ForeignKey(
                        name: "FK_CustomerCustomerProduct_CustomersProducts_CustomerProductsCustomerProductId",
                        column: x => x.CustomerProductsCustomerProductId,
                        principalTable: "CustomersProducts",
                        principalColumn: "CustomerProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerCustomerProduct_Customers_CustomersPropertiesCustomerId",
                        column: x => x.CustomersPropertiesCustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerProductProduct",
                columns: table => new
                {
                    CustomerProductsCustomerProductId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerPropertiesProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerProductProduct", x => new { x.CustomerProductsCustomerProductId, x.CustomerPropertiesProductId });
                    table.ForeignKey(
                        name: "FK_CustomerProductProduct_CustomersProducts_CustomerProductsCustomerProductId",
                        column: x => x.CustomerProductsCustomerProductId,
                        principalTable: "CustomersProducts",
                        principalColumn: "CustomerProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerProductProduct_Products_CustomerPropertiesProductId",
                        column: x => x.CustomerPropertiesProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCustomerProduct_CustomersPropertiesCustomerId",
                table: "CustomerCustomerProduct",
                column: "CustomersPropertiesCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProductProduct_CustomerPropertiesProductId",
                table: "CustomerProductProduct",
                column: "CustomerPropertiesProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerCustomerProduct");

            migrationBuilder.DropTable(
                name: "CustomerProductProduct");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "CustomersProducts");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
