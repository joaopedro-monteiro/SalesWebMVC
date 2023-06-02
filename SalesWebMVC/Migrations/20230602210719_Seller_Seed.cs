using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWebMVC.Migrations
{
    /// <inheritdoc />
    public partial class Seller_Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                 table: "Seller",
                 columns: new[] { "Id", "DepartmentId", "Email", "Name", "baseSalary", "birthDate" },
                 values: new object[,]
                 {
                                { 1, 1, "bob@gmail.com", "Bob Brown", 4000.0, new DateTime(1986, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                                { 2, 2, "mary@gmail.com", "Mary Jane", 3500.0, new DateTime(1988, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                                { 3, 1, "alex@gmail.com", "Alex Grey", 2200.0, new DateTime(1979, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                                { 4, 4, "donald@gmail.com", "Donald Blue", 3000.0, new DateTime(1976, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                                { 5, 3, "peter@gmail.com", "Peter Parker", 1000.0, new DateTime(1953, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                                { 6, 2, "bruce@gmail.com", "Bruce Wayne", 3000.0, new DateTime(1999, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
