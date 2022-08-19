using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Plantbook.Data.Migrations
{
    public partial class AddedNoteToPlantPostingModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastFertilized",
                table: "PlantPostings",
                newName: "Note");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Note",
                table: "PlantPostings",
                newName: "LastFertilized");
        }
    }
}
