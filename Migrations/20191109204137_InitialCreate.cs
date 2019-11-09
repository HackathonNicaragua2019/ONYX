using Microsoft.EntityFrameworkCore.Migrations;

namespace OnyxPlataform.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserDataList",
                columns: table => new
                {
                    UserDataID = table.Column<string>(nullable: false),
                    UserDataFirstName = table.Column<string>(nullable: true),
                    UserDataLastName = table.Column<string>(nullable: true),
                    UserDataCreditCard = table.Column<string>(nullable: true),
                    UserDataCreditCardPin = table.Column<string>(nullable: true),
                    UserDataPostalCode = table.Column<string>(nullable: true),
                    UserDataDirection = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDataList", x => x.UserDataID);
                });

            migrationBuilder.CreateTable(
                name: "BuyUserList",
                columns: table => new
                {
                    BuyUserId = table.Column<string>(nullable: false),
                    UserDataId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyUserList", x => x.BuyUserId);
                    table.ForeignKey(
                        name: "FK_BuyUserList_UserDataList_UserDataId",
                        column: x => x.UserDataId,
                        principalTable: "UserDataList",
                        principalColumn: "UserDataID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassRoomList",
                columns: table => new
                {
                    ClassRoomId = table.Column<string>(nullable: false),
                    UserDataId = table.Column<string>(nullable: true),
                    ClassRoomName = table.Column<string>(nullable: true),
                    ClassRoomDirections = table.Column<string>(nullable: true),
                    ClassRoomDescriptions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRoomList", x => x.ClassRoomId);
                    table.ForeignKey(
                        name: "FK_ClassRoomList_UserDataList_UserDataId",
                        column: x => x.UserDataId,
                        principalTable: "UserDataList",
                        principalColumn: "UserDataID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StoreList",
                columns: table => new
                {
                    StoreId = table.Column<string>(nullable: false),
                    UserDataId = table.Column<string>(nullable: true),
                    StoreName = table.Column<string>(nullable: true),
                    StoreDescription = table.Column<string>(nullable: true),
                    StoreDirection = table.Column<string>(nullable: true),
                    StoreMotto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreList", x => x.StoreId);
                    table.ForeignKey(
                        name: "FK_StoreList_UserDataList_UserDataId",
                        column: x => x.UserDataId,
                        principalTable: "UserDataList",
                        principalColumn: "UserDataID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseList",
                columns: table => new
                {
                    CourseId = table.Column<string>(nullable: false),
                    ClassRoomId = table.Column<string>(nullable: true),
                    CourseName = table.Column<string>(nullable: true),
                    CourseInitialDate = table.Column<string>(nullable: true),
                    CourseFinalDate = table.Column<string>(nullable: true),
                    CourseDescription = table.Column<string>(nullable: true),
                    CourseCapacity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseList", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_CourseList_ClassRoomList_ClassRoomId",
                        column: x => x.ClassRoomId,
                        principalTable: "ClassRoomList",
                        principalColumn: "ClassRoomId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogueList",
                columns: table => new
                {
                    CatalogueID = table.Column<string>(nullable: false),
                    StoreId = table.Column<string>(nullable: true),
                    CatalogueProductName = table.Column<string>(nullable: true),
                    CatalogueProductModel = table.Column<string>(nullable: true),
                    CatalogueProductBrand = table.Column<string>(nullable: true),
                    CatalogueProductBuilder = table.Column<string>(nullable: true),
                    CatalogueProductType = table.Column<string>(nullable: true),
                    CatalogueProductDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogueList", x => x.CatalogueID);
                    table.ForeignKey(
                        name: "FK_CatalogueList_StoreList_StoreId",
                        column: x => x.StoreId,
                        principalTable: "StoreList",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductList",
                columns: table => new
                {
                    ProductID = table.Column<string>(nullable: false),
                    CatalogueId = table.Column<string>(nullable: true),
                    ProductSerialNumber = table.Column<string>(nullable: true),
                    ProductPrice = table.Column<double>(nullable: false),
                    ProductColor = table.Column<string>(nullable: true),
                    ProductWeight = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductList", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_ProductList_CatalogueList_CatalogueId",
                        column: x => x.CatalogueId,
                        principalTable: "CatalogueList",
                        principalColumn: "CatalogueID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BuyDetailsList",
                columns: table => new
                {
                    BuyDetailsId = table.Column<string>(nullable: false),
                    ProductId = table.Column<string>(nullable: true),
                    BuyDetailsQuantity = table.Column<int>(nullable: false),
                    BuyDetailsTotalPrice = table.Column<double>(nullable: false),
                    BuyDetailsDiscount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyDetailsList", x => x.BuyDetailsId);
                    table.ForeignKey(
                        name: "FK_BuyDetailsList_ProductList_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductList",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BuyList",
                columns: table => new
                {
                    BuyId = table.Column<string>(nullable: false),
                    StoreId = table.Column<string>(nullable: true),
                    CatalogueId = table.Column<string>(nullable: true),
                    BuyDetailsId = table.Column<string>(nullable: true),
                    BuyDate = table.Column<string>(nullable: true),
                    BuyDateDeliver = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyList", x => x.BuyId);
                    table.ForeignKey(
                        name: "FK_BuyList_BuyDetailsList_BuyDetailsId",
                        column: x => x.BuyDetailsId,
                        principalTable: "BuyDetailsList",
                        principalColumn: "BuyDetailsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BuyList_CatalogueList_CatalogueId",
                        column: x => x.CatalogueId,
                        principalTable: "CatalogueList",
                        principalColumn: "CatalogueID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BuyList_StoreList_StoreId",
                        column: x => x.StoreId,
                        principalTable: "StoreList",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuyDetailsList_ProductId",
                table: "BuyDetailsList",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BuyList_BuyDetailsId",
                table: "BuyList",
                column: "BuyDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_BuyList_CatalogueId",
                table: "BuyList",
                column: "CatalogueId");

            migrationBuilder.CreateIndex(
                name: "IX_BuyList_StoreId",
                table: "BuyList",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_BuyUserList_UserDataId",
                table: "BuyUserList",
                column: "UserDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogueList_StoreId",
                table: "CatalogueList",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoomList_UserDataId",
                table: "ClassRoomList",
                column: "UserDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseList_ClassRoomId",
                table: "CourseList",
                column: "ClassRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductList_CatalogueId",
                table: "ProductList",
                column: "CatalogueId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreList_UserDataId",
                table: "StoreList",
                column: "UserDataId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuyList");

            migrationBuilder.DropTable(
                name: "BuyUserList");

            migrationBuilder.DropTable(
                name: "CourseList");

            migrationBuilder.DropTable(
                name: "BuyDetailsList");

            migrationBuilder.DropTable(
                name: "ClassRoomList");

            migrationBuilder.DropTable(
                name: "ProductList");

            migrationBuilder.DropTable(
                name: "CatalogueList");

            migrationBuilder.DropTable(
                name: "StoreList");

            migrationBuilder.DropTable(
                name: "UserDataList");
        }
    }
}
