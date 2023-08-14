using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Meferi.Migrations
{
	/// <inheritdoc />
	public partial class ChangeIds : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.RenameColumn(
	name: "Id",
	table: "Categories",
	newName: "CategoryId");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Products");

			migrationBuilder.DropTable(
				name: "Categories");
		}
	}
}
