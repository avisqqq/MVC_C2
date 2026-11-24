using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MojeCV.Migrations
{
    /// <inheritdoc />
    public partial class AddOsobaDoswiadczenie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OsobaId",
                table: "Doswiadczenie",
                type: "INTEGER",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Doswiadczenie_OsobaId",
                table: "Doswiadczenie",
                column: "OsobaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doswiadczenie_Osoba_OsobaId",
                table: "Doswiadczenie",
                column: "OsobaId",
                principalTable: "Osoba",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doswiadczenie_Osoba_OsobaId",
                table: "Doswiadczenie");

            migrationBuilder.DropIndex(
                name: "IX_Doswiadczenie_OsobaId",
                table: "Doswiadczenie");

            migrationBuilder.DropColumn(
                name: "OsobaId",
                table: "Doswiadczenie");
        }
    }
}
