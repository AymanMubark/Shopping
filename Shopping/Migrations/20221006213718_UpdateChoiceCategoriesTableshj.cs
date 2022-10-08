using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping.Migrations
{
    public partial class UpdateChoiceCategoriesTableshj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ChoiceCategoryId",
                table: "ProductChoices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductChoices_ChoiceCategoryId",
                table: "ProductChoices",
                column: "ChoiceCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductChoices_ChoiceCategories_ChoiceCategoryId",
                table: "ProductChoices",
                column: "ChoiceCategoryId",
                principalTable: "ChoiceCategories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductChoices_ChoiceCategories_ChoiceCategoryId",
                table: "ProductChoices");

            migrationBuilder.DropIndex(
                name: "IX_ProductChoices_ChoiceCategoryId",
                table: "ProductChoices");

            migrationBuilder.DropColumn(
                name: "ChoiceCategoryId",
                table: "ProductChoices");
        }
    }
}
