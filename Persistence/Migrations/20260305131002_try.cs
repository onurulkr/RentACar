using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class @try : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Fuels_FuelId",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "FueldId",
                table: "Models");

            migrationBuilder.AlterColumn<Guid>(
                name: "FuelId",
                table: "Models",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Fuels_FuelId",
                table: "Models",
                column: "FuelId",
                principalTable: "Fuels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Fuels_FuelId",
                table: "Models");

            migrationBuilder.AlterColumn<Guid>(
                name: "FuelId",
                table: "Models",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "FueldId",
                table: "Models",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Fuels_FuelId",
                table: "Models",
                column: "FuelId",
                principalTable: "Fuels",
                principalColumn: "Id");
        }
    }
}
