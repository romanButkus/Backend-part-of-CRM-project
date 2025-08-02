using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Outlets",
                columns: table => new
                {
                    OutletId = table
                        .Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outlets", x => x.OutletId);
                }
            );

            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(
                        type: "TEXT",
                        maxLength: 20,
                        nullable: false
                    ),
                    Salary = table.Column<decimal>(type: "TEXT", nullable: false),
                    OutletId = table.Column<int>(type: "INTEGER", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employers_Outlets_OutletId",
                        column: x => x.OutletId,
                        principalTable: "Outlets",
                        principalColumn: "OutletId",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    OutletId = table.Column<int>(type: "INTEGER", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Outlets_OutletId",
                        column: x => x.OutletId,
                        principalTable: "Outlets",
                        principalColumn: "OutletId",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateIndex(
                name: "IX_Employers_OutletId",
                table: "Employers",
                column: "OutletId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Products_OutletId",
                table: "Products",
                column: "OutletId"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Employers");

            migrationBuilder.DropTable(name: "Products");

            migrationBuilder.DropTable(name: "Outlets");
        }
    }
}
