using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveSlug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogItemFeature_CatalogItems_CatalogItemId",
                table: "CatalogItemFeature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogItemFeature",
                table: "CatalogItemFeature");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "CatalogItems");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "UserAddresses",
                newName: "UserAddresses",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "Payments",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Orders",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "OrderItems",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "DiscountUsageHistories",
                newName: "DiscountUsageHistories",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Discount",
                newName: "Discount",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "CatalogType",
                newName: "CatalogType",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "CatalogItems",
                newName: "CatalogItems",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "CatalogItemImage",
                newName: "CatalogItemImage",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "CatalogItemFavourites",
                newName: "CatalogItemFavourites",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "CatalogItemDiscount",
                newName: "CatalogItemDiscount",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "CatalogItemComments",
                newName: "CatalogItemComments",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "CatalogBrand",
                newName: "CatalogBrand",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Baskets",
                newName: "Baskets",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "BasketItems",
                newName: "BasketItems",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Banners",
                newName: "Banners",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "CatalogItemFeature",
                newName: "CatalogItemFeatures",
                newSchema: "dbo");

            migrationBuilder.RenameIndex(
                name: "IX_CatalogItemFeature_CatalogItemId",
                schema: "dbo",
                table: "CatalogItemFeatures",
                newName: "IX_CatalogItemFeatures_CatalogItemId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                schema: "dbo",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 759, DateTimeKind.Local).AddTicks(5468),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 28, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                schema: "dbo",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 759, DateTimeKind.Local).AddTicks(4091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 28, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                schema: "dbo",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 758, DateTimeKind.Local).AddTicks(9786),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 28, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                schema: "dbo",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 759, DateTimeKind.Local).AddTicks(2420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 28, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                schema: "dbo",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 758, DateTimeKind.Local).AddTicks(7030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 27, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                schema: "dbo",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 758, DateTimeKind.Local).AddTicks(4988),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 27, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                schema: "dbo",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 757, DateTimeKind.Local).AddTicks(5682),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 26, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                schema: "dbo",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 758, DateTimeKind.Local).AddTicks(2986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 27, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                schema: "dbo",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 758, DateTimeKind.Local).AddTicks(241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 27, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                schema: "dbo",
                table: "CatalogItemComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 757, DateTimeKind.Local).AddTicks(8802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 27, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                schema: "dbo",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 757, DateTimeKind.Local).AddTicks(3436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 26, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                schema: "dbo",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 752, DateTimeKind.Local).AddTicks(2643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 19, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                schema: "dbo",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 757, DateTimeKind.Local).AddTicks(1571),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 26, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                schema: "dbo",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 758, DateTimeKind.Local).AddTicks(1583),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 27, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogItemFeatures",
                schema: "dbo",
                table: "CatalogItemFeatures",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogItemFeatures_CatalogItems_CatalogItemId",
                schema: "dbo",
                table: "CatalogItemFeatures",
                column: "CatalogItemId",
                principalSchema: "dbo",
                principalTable: "CatalogItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogItemFeatures_CatalogItems_CatalogItemId",
                schema: "dbo",
                table: "CatalogItemFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogItemFeatures",
                schema: "dbo",
                table: "CatalogItemFeatures");

            migrationBuilder.RenameTable(
                name: "UserAddresses",
                schema: "dbo",
                newName: "UserAddresses");

            migrationBuilder.RenameTable(
                name: "Payments",
                schema: "dbo",
                newName: "Payments");

            migrationBuilder.RenameTable(
                name: "Orders",
                schema: "dbo",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                schema: "dbo",
                newName: "OrderItems");

            migrationBuilder.RenameTable(
                name: "DiscountUsageHistories",
                schema: "dbo",
                newName: "DiscountUsageHistories");

            migrationBuilder.RenameTable(
                name: "Discount",
                schema: "dbo",
                newName: "Discount");

            migrationBuilder.RenameTable(
                name: "CatalogType",
                schema: "dbo",
                newName: "CatalogType");

            migrationBuilder.RenameTable(
                name: "CatalogItems",
                schema: "dbo",
                newName: "CatalogItems");

            migrationBuilder.RenameTable(
                name: "CatalogItemImage",
                schema: "dbo",
                newName: "CatalogItemImage");

            migrationBuilder.RenameTable(
                name: "CatalogItemFavourites",
                schema: "dbo",
                newName: "CatalogItemFavourites");

            migrationBuilder.RenameTable(
                name: "CatalogItemDiscount",
                schema: "dbo",
                newName: "CatalogItemDiscount");

            migrationBuilder.RenameTable(
                name: "CatalogItemComments",
                schema: "dbo",
                newName: "CatalogItemComments");

            migrationBuilder.RenameTable(
                name: "CatalogBrand",
                schema: "dbo",
                newName: "CatalogBrand");

            migrationBuilder.RenameTable(
                name: "Baskets",
                schema: "dbo",
                newName: "Baskets");

            migrationBuilder.RenameTable(
                name: "BasketItems",
                schema: "dbo",
                newName: "BasketItems");

            migrationBuilder.RenameTable(
                name: "Banners",
                schema: "dbo",
                newName: "Banners");

            migrationBuilder.RenameTable(
                name: "CatalogItemFeatures",
                schema: "dbo",
                newName: "CatalogItemFeature");

            migrationBuilder.RenameIndex(
                name: "IX_CatalogItemFeatures_CatalogItemId",
                table: "CatalogItemFeature",
                newName: "IX_CatalogItemFeature_CatalogItemId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 28, DateTimeKind.Local).AddTicks(7874),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 759, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 28, DateTimeKind.Local).AddTicks(6539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 759, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 28, DateTimeKind.Local).AddTicks(2265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 758, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 28, DateTimeKind.Local).AddTicks(4900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 759, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 27, DateTimeKind.Local).AddTicks(9622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 758, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 27, DateTimeKind.Local).AddTicks(7638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 758, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 26, DateTimeKind.Local).AddTicks(8742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 757, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "CatalogItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 27, DateTimeKind.Local).AddTicks(6134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 758, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 27, DateTimeKind.Local).AddTicks(3356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 758, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 27, DateTimeKind.Local).AddTicks(1817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 757, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 26, DateTimeKind.Local).AddTicks(6722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 757, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 19, DateTimeKind.Local).AddTicks(6590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 752, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 26, DateTimeKind.Local).AddTicks(5078),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 757, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 6, 31, 39, 27, DateTimeKind.Local).AddTicks(4645),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 20, 16, 8, 43, 758, DateTimeKind.Local).AddTicks(1583));

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogItemFeature",
                table: "CatalogItemFeature",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogItemFeature_CatalogItems_CatalogItemId",
                table: "CatalogItemFeature",
                column: "CatalogItemId",
                principalTable: "CatalogItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
