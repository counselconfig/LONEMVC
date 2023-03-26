using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LONE.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjectLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjectAltFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectAltLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectDateofBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjectDateOfDeath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectCountryOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRetypeEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserTownOrCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCounty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPostcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCountry = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");
        }
    }
}
