using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Microsoft_WebSite.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutUsTable",
                columns: table => new
                {
                    AboutUsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutUsTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutUsContent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUsTable", x => x.AboutUsID);
                });

            migrationBuilder.CreateTable(
                name: "ContactUsTable",
                columns: table => new
                {
                    ContactUsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsTable", x => x.ContactUsID);
                });

            migrationBuilder.CreateTable(
                name: "PackageFeatures",
                columns: table => new
                {
                    PackageFeatureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageFeatureTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageFeatures", x => x.PackageFeatureID);
                });

            migrationBuilder.CreateTable(
                name: "PackageProductUnits",
                columns: table => new
                {
                    PackageProductUnitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageProductUnitTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PackageProductUnitContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PackageProductUnitPrice = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageProductUnits", x => x.PackageProductUnitID);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    PackageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PackageContent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.PackageID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userRole = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "PackagePackageFeature",
                columns: table => new
                {
                    PackageFeaturesPackageFeatureID = table.Column<int>(type: "int", nullable: false),
                    PackagesPackageID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackagePackageFeature", x => new { x.PackageFeaturesPackageFeatureID, x.PackagesPackageID });
                    table.ForeignKey(
                        name: "FK_PackagePackageFeature_PackageFeatures_PackageFeaturesPackageFeatureID",
                        column: x => x.PackageFeaturesPackageFeatureID,
                        principalTable: "PackageFeatures",
                        principalColumn: "PackageFeatureID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackagePackageFeature_Packages_PackagesPackageID",
                        column: x => x.PackagesPackageID,
                        principalTable: "Packages",
                        principalColumn: "PackageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PackagePackageProductUnit",
                columns: table => new
                {
                    PackageProductUnitsPackageProductUnitID = table.Column<int>(type: "int", nullable: false),
                    PackagesPackageID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackagePackageProductUnit", x => new { x.PackageProductUnitsPackageProductUnitID, x.PackagesPackageID });
                    table.ForeignKey(
                        name: "FK_PackagePackageProductUnit_PackageProductUnits_PackageProductUnitsPackageProductUnitID",
                        column: x => x.PackageProductUnitsPackageProductUnitID,
                        principalTable: "PackageProductUnits",
                        principalColumn: "PackageProductUnitID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackagePackageProductUnit_Packages_PackagesPackageID",
                        column: x => x.PackagesPackageID,
                        principalTable: "Packages",
                        principalColumn: "PackageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PackageFeatures",
                columns: new[] { "PackageFeatureID", "PackageFeatureTitle" },
                values: new object[,]
                {
                    { 1, "Public" },
                    { 2, "Private" },
                    { 3, "Permissions" },
                    { 4, "Sharing" },
                    { 5, "Unlimited members" },
                    { 6, "Extra security" }
                });

            migrationBuilder.InsertData(
                table: "PackageProductUnits",
                columns: new[] { "PackageProductUnitID", "PackageProductUnitContent", "PackageProductUnitPrice", "PackageProductUnitTitle" },
                values: new object[,]
                {
                    { 1, "10 users included", "100", "users included" },
                    { 2, "2 GB of storage", "10", "GB of storage" }
                });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "PackageID", "PackageContent", "PackageTitle" },
                values: new object[,]
                {
                    { 1, "Free Plan", "Free" },
                    { 2, "Pro Plan", "Pro" },
                    { 3, "Enterprise Plan", "Enterprise" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "UserEmail", "UserPassword", "UserUsername", "userRole" },
                values: new object[] { 1, "trkhamarat@gmail.com", "123456", "trkhamarat", "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_PackagePackageFeature_PackagesPackageID",
                table: "PackagePackageFeature",
                column: "PackagesPackageID");

            migrationBuilder.CreateIndex(
                name: "IX_PackagePackageProductUnit_PackagesPackageID",
                table: "PackagePackageProductUnit",
                column: "PackagesPackageID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUsTable");

            migrationBuilder.DropTable(
                name: "ContactUsTable");

            migrationBuilder.DropTable(
                name: "PackagePackageFeature");

            migrationBuilder.DropTable(
                name: "PackagePackageProductUnit");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "PackageFeatures");

            migrationBuilder.DropTable(
                name: "PackageProductUnits");

            migrationBuilder.DropTable(
                name: "Packages");
        }
    }
}
