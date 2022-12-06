using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final4360.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "package",
                columns: table => new
                {
                    PackageID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ResidentID = table.Column<int>(type: "INTEGER", nullable: false),
                    PostingID = table.Column<int>(type: "INTEGER", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PickupDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_package", x => x.PackageID);
                });

            migrationBuilder.CreateTable(
                name: "posting",
                columns: table => new
                {
                    PostingID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Service = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posting", x => x.PostingID);
                });

            migrationBuilder.CreateTable(
                name: "resident",
                columns: table => new
                {
                    ResidentID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    UnitNumber = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resident", x => x.ResidentID);
                });

            migrationBuilder.CreateTable(
                name: "staff",
                columns: table => new
                {
                    StaffID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StaffUsername = table.Column<string>(type: "TEXT", nullable: false),
                    StaffPassword = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staff", x => x.StaffID);
                });

            migrationBuilder.CreateTable(
                name: "unknown",
                columns: table => new
                {
                    UnknownID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    PostingID = table.Column<int>(type: "INTEGER", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unknown", x => x.UnknownID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "package");

            migrationBuilder.DropTable(
                name: "posting");

            migrationBuilder.DropTable(
                name: "resident");

            migrationBuilder.DropTable(
                name: "staff");

            migrationBuilder.DropTable(
                name: "unknown");
        }
    }
}
