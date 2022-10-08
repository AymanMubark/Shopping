using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping.Migrations
{
    public partial class addChoiceCategoriesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Choices_ChoiceCategory_ChoiceCategoryId",
                table: "Choices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChoiceCategory",
                table: "ChoiceCategory");

            migrationBuilder.RenameTable(
                name: "ChoiceCategory",
                newName: "ChoiceCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChoiceCategories",
                table: "ChoiceCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Choices_ChoiceCategories_ChoiceCategoryId",
                table: "Choices",
                column: "ChoiceCategoryId",
                principalTable: "ChoiceCategories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Choices_ChoiceCategories_ChoiceCategoryId",
                table: "Choices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChoiceCategories",
                table: "ChoiceCategories");

            migrationBuilder.RenameTable(
                name: "ChoiceCategories",
                newName: "ChoiceCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChoiceCategory",
                table: "ChoiceCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Choices_ChoiceCategory_ChoiceCategoryId",
                table: "Choices",
                column: "ChoiceCategoryId",
                principalTable: "ChoiceCategory",
                principalColumn: "Id");
        }
    }
}
