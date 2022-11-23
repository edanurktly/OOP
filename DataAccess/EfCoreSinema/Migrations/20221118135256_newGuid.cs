using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreSinema.Migrations
{
    /// <inheritdoc />
    public partial class newGuid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Seanslar",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("bde8f756-5973-493c-966b-be4e6f61f938"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Salonlar",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("1f8122ef-8759-4a93-96ea-eb98ba1f2051"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Kategoriler",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("f09b5a5e-86b4-42d8-95a8-688e44cce24c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Haftalar",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("3c1a1788-1914-4e70-9c6d-e00db6f5cf0b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Gosterimler",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("d468e8d8-dfa1-4a98-8e12-2260f8c635d9"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Filmler",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00c29cd0-6cd1-4a34-89b7-11965d71f043"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Seanslar",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("bde8f756-5973-493c-966b-be4e6f61f938"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Salonlar",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("1f8122ef-8759-4a93-96ea-eb98ba1f2051"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Kategoriler",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("f09b5a5e-86b4-42d8-95a8-688e44cce24c"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Haftalar",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("3c1a1788-1914-4e70-9c6d-e00db6f5cf0b"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Gosterimler",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("d468e8d8-dfa1-4a98-8e12-2260f8c635d9"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Filmler",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00c29cd0-6cd1-4a34-89b7-11965d71f043"));
        }
    }
}
