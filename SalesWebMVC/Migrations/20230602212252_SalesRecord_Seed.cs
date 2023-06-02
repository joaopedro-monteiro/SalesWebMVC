using Microsoft.EntityFrameworkCore.Migrations;
using SalesWebMVC.Models.Enums;

#nullable disable

namespace SalesWebMVC.Migrations
{


    /// <inheritdoc />
    public partial class SalesRecord_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SalesRecord",
                columns: new[] { "Id", "Date", "Amount", "Status", "SellerId" },
                values: new object[,]
                {
                    {1, new DateTime(2018, 09, 25), 11000.0, (int)SaleStatus.Billed, 1},
                    {2, new DateTime(2018, 09, 4), 7000.0, (int)SaleStatus.Billed, 5},
                    {3, new DateTime(2018, 09, 13), 4000.0, (int)SaleStatus.Canceled, 4},
                    {4, new DateTime(2018, 09, 1), 8000.0, (int)SaleStatus.Billed, 1},
                    {5, new DateTime(2018, 09, 21), 3000.0, (int)SaleStatus.Billed, 3},
                    {6, new DateTime(2018, 09, 15), 2000.0, (int)SaleStatus.Billed, 1},
                    {7, new DateTime(2018, 09, 28), 13000.0, (int)SaleStatus.Billed, 2},
                    {8, new DateTime(2018, 09, 11), 4000.0, (int)SaleStatus.Billed, 4},
                    {9, new DateTime(2018, 09, 14), 11000.0, (int)SaleStatus.Pending, 6},
                    {10, new DateTime(2018, 09, 7), 9000.0, (int)SaleStatus.Billed, 6},
                    {11, new DateTime(2018, 09, 13), 6000.0, (int)SaleStatus.Billed, 2},
                    {12, new DateTime(2018, 09, 25), 7000.0, (int)SaleStatus.Pending, 3},
                    {13, new DateTime(2018, 09, 29), 10000.0, (int)SaleStatus.Billed, 4},
                    {14, new DateTime(2018, 09, 4), 3000.0, (int)SaleStatus.Billed, 5},
                    {15, new DateTime(2018, 09, 12), 4000.0, (int)SaleStatus.Billed, 1},
                    {16, new DateTime(2018, 10, 5), 2000.0, (int)SaleStatus.Billed, 4},
                    {17, new DateTime(2018, 10, 1), 12000.0, (int)SaleStatus.Billed, 1},
                    {18, new DateTime(2018, 10, 24), 6000.0, (int)SaleStatus.Billed, 3},
                    {19, new DateTime(2018, 10, 22), 8000.0, (int)SaleStatus.Billed, 5},
                    {20, new DateTime(2018, 10, 15), 8000.0, (int)SaleStatus.Billed, 6},
                    {21, new DateTime(2018, 10, 17), 9000.0, (int)SaleStatus.Billed, 2},
                    {22, new DateTime(2018, 10, 24), 4000.0, (int)SaleStatus.Billed, 4},
                    {23, new DateTime(2018, 10, 19), 11000.0, (int)SaleStatus.Canceled, 2},
                    {24, new DateTime(2018, 10, 12), 8000.0, (int)SaleStatus.Billed, 5},
                    {25, new DateTime(2018, 10, 31), 7000.0, (int)SaleStatus.Billed, 3},
                    {26, new DateTime(2018, 10, 6), 5000.0, (int)SaleStatus.Billed, 4},
                    {27, new DateTime(2018, 10, 13), 9000.0, (int)SaleStatus.Pending, 1},
                    {28, new DateTime(2018, 10, 7), 4000.0, (int)SaleStatus.Billed, 3},
                    {29, new DateTime(2018, 10, 23), 12000.0, (int)SaleStatus.Billed, 5},
                    {30, new DateTime(2018, 10, 12), 5000.0, (int)SaleStatus.Billed, 2},
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
