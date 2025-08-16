using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace instapostDatalayer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryDb",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    categoryName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryDb", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UsersDb",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    username = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersDb", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryEntityUserEntity",
                columns: table => new
                {
                    userInterestInCategoryid = table.Column<long>(type: "bigint", nullable: false),
                    usersid = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryEntityUserEntity", x => new { x.userInterestInCategoryid, x.usersid });
                    table.ForeignKey(
                        name: "FK_CategoryEntityUserEntity_CategoryDb_userInterestInCategoryid",
                        column: x => x.userInterestInCategoryid,
                        principalTable: "CategoryDb",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryEntityUserEntity_UsersDb_usersid",
                        column: x => x.usersid,
                        principalTable: "UsersDb",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostDb",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    postDesc = table.Column<string>(type: "text", nullable: false),
                    UserEntityid = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostDb", x => x.id);
                    table.ForeignKey(
                        name: "FK_PostDb_UsersDb_UserEntityid",
                        column: x => x.UserEntityid,
                        principalTable: "UsersDb",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "CategoryEntityPostEntity",
                columns: table => new
                {
                    postCategoryid = table.Column<long>(type: "bigint", nullable: false),
                    postsid = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryEntityPostEntity", x => new { x.postCategoryid, x.postsid });
                    table.ForeignKey(
                        name: "FK_CategoryEntityPostEntity_CategoryDb_postCategoryid",
                        column: x => x.postCategoryid,
                        principalTable: "CategoryDb",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryEntityPostEntity_PostDb_postsid",
                        column: x => x.postsid,
                        principalTable: "PostDb",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryEntityPostEntity_postsid",
                table: "CategoryEntityPostEntity",
                column: "postsid");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryEntityUserEntity_usersid",
                table: "CategoryEntityUserEntity",
                column: "usersid");

            migrationBuilder.CreateIndex(
                name: "IX_PostDb_UserEntityid",
                table: "PostDb",
                column: "UserEntityid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryEntityPostEntity");

            migrationBuilder.DropTable(
                name: "CategoryEntityUserEntity");

            migrationBuilder.DropTable(
                name: "PostDb");

            migrationBuilder.DropTable(
                name: "CategoryDb");

            migrationBuilder.DropTable(
                name: "UsersDb");
        }
    }
}
