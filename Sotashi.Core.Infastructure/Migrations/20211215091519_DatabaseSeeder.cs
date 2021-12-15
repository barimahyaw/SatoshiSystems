using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sotashi.Core.Infastructure.Migrations
{
    public partial class DatabaseSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea317"), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(3447), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(3450), "Dave" },
                    { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea318"), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(3588), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(3589), "George" },
                    { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea319"), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(3610), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(3611), "Fiona" },
                    { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea320"), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(3628), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(3630), "Rory" },
                    { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea321"), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(3646), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(3647), "Olivia" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea314"), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 332, DateTimeKind.Utc).AddTicks(1643), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 332, DateTimeKind.Utc).AddTicks(2126), "Laptop" },
                    { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315"), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(2673), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(2678), "Keyboard" },
                    { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea316"), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(2758), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(2760), "Keyboard" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "CustomerId", "LastModifiedBy", "LastModifiedOn", "Price", "ProductId" },
                values: new object[,]
                {
                    { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea322"), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(4937), new Guid("cfb88e29-4744-48c0-94fa-b25b92dea317"), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(4940), 900.0, new Guid("cfb88e29-4744-48c0-94fa-b25b92dea314") },
                    { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea326"), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(5213), new Guid("cfb88e29-4744-48c0-94fa-b25b92dea321"), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(5214), 600.0, new Guid("cfb88e29-4744-48c0-94fa-b25b92dea314") },
                    { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea323"), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(5155), new Guid("cfb88e29-4744-48c0-94fa-b25b92dea318"), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(5156), 35.0, new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315") },
                    { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea324"), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(5176), new Guid("cfb88e29-4744-48c0-94fa-b25b92dea319"), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(5178), 5.0, new Guid("cfb88e29-4744-48c0-94fa-b25b92dea316") },
                    { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea325"), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(5195), new Guid("cfb88e29-4744-48c0-94fa-b25b92dea320"), new Guid("825f1646-9fa2-41c2-97c2-1bcc3912e890"), new DateTime(2021, 12, 15, 9, 15, 19, 333, DateTimeKind.Utc).AddTicks(5197), 3.0, new Guid("cfb88e29-4744-48c0-94fa-b25b92dea316") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea322"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea323"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea324"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea325"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea326"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea317"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea318"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea319"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea320"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea321"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea314"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea316"));
        }
    }
}
