using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaleProject.Migrations
{
    /// <inheritdoc />
    public partial class fixrelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SupplierContactInfos_SupplierId",
                table: "SupplierContactInfos");

            migrationBuilder.DropIndex(
                name: "IX_CustomerContactInfos_CustomerId",
                table: "CustomerContactInfos");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Suppliers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Suppliers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SupplierContactInfos_SupplierId",
                table: "SupplierContactInfos",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerContactInfos_CustomerId",
                table: "CustomerContactInfos",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SupplierContactInfos_SupplierId",
                table: "SupplierContactInfos");

            migrationBuilder.DropIndex(
                name: "IX_CustomerContactInfos_CustomerId",
                table: "CustomerContactInfos");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Customers");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierContactInfos_SupplierId",
                table: "SupplierContactInfos",
                column: "SupplierId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerContactInfos_CustomerId",
                table: "CustomerContactInfos",
                column: "CustomerId",
                unique: true);
        }
    }
}
