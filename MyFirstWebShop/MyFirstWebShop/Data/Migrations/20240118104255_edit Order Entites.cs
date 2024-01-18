using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstWebShop.Migrations
{
    /// <inheritdoc />
    public partial class editOrderEntites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ProductPrice",
                table: "Products",
                type: "decimal(12,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,3)");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Products",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Products",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "OrdersPos",
                type: "decimal(12,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,3)");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "OrdersPos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OrdersPos",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "OrdersPos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "OrdersPos",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Orders",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Orders",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CreatedBy",
                table: "Products",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ModifiedBy",
                table: "Products",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersPos_CreatedBy",
                table: "OrdersPos",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersPos_ModifiedBy",
                table: "OrdersPos",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CreatedBy",
                table: "Orders",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ModifiedBy",
                table: "Orders",
                column: "ModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_CreatedBy",
                table: "Orders",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_ModifiedBy",
                table: "Orders",
                column: "ModifiedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersPos_AspNetUsers_CreatedBy",
                table: "OrdersPos",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersPos_AspNetUsers_ModifiedBy",
                table: "OrdersPos",
                column: "ModifiedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_CreatedBy",
                table: "Products",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_ModifiedBy",
                table: "Products",
                column: "ModifiedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_CreatedBy",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_ModifiedBy",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdersPos_AspNetUsers_CreatedBy",
                table: "OrdersPos");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdersPos_AspNetUsers_ModifiedBy",
                table: "OrdersPos");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_CreatedBy",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_ModifiedBy",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CreatedBy",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ModifiedBy",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_OrdersPos_CreatedBy",
                table: "OrdersPos");

            migrationBuilder.DropIndex(
                name: "IX_OrdersPos_ModifiedBy",
                table: "OrdersPos");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CreatedBy",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ModifiedBy",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "OrdersPos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OrdersPos");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "OrdersPos");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "OrdersPos");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Orders");

            migrationBuilder.AlterColumn<decimal>(
                name: "ProductPrice",
                table: "Products",
                type: "decimal(8,3)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "OrdersPos",
                type: "decimal(8,3)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)");
        }
    }
}
