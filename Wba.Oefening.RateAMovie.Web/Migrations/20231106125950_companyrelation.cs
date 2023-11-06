using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wba.Oefening.RateAMovie.Web.Migrations
{
    public partial class companyrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CompanyId",
                table: "Movies",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CompanyId",
                table: "Movies",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Companies_CompanyId",
                table: "Movies",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Companies_CompanyId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CompanyId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Movies");
        }
    }
}
