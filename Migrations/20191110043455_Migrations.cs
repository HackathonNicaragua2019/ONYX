using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnyxPlataform.Migrations
{
    public partial class Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BuyList");

            migrationBuilder.DropTable(
                name: "BuyUserList");

            migrationBuilder.DropTable(
                name: "CourseList");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
