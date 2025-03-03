using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBWork.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "order",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int", nullable: false),
                    cost = table.Column<int>(type: "int", nullable: true),
                    time_execution = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fullname_client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order", x => x.order_id);
                });

            migrationBuilder.CreateTable(
                name: "department",
                columns: table => new
                {
                    department_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    director_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_department", x => x.department_id);
                });

            migrationBuilder.CreateTable(
                name: "staff",
                columns: table => new
                {
                    staff_id = table.Column<int>(type: "int", nullable: false),
                    surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    patronymic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    telephone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    department_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staff", x => x.staff_id);
                    table.ForeignKey(
                        name: "FK_staff_department",
                        column: x => x.department_id,
                        principalTable: "department",
                        principalColumn: "department_id");
                });

            migrationBuilder.CreateTable(
                name: "staff_order",
                columns: table => new
                {
                    order_staff_id = table.Column<int>(type: "int", nullable: false),
                    staff_id = table.Column<int>(type: "int", nullable: false),
                    order_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staff_order", x => x.order_staff_id);
                    table.ForeignKey(
                        name: "FK_staff_order_order",
                        column: x => x.order_id,
                        principalTable: "order",
                        principalColumn: "order_id");
                    table.ForeignKey(
                        name: "FK_staff_order_staff",
                        column: x => x.staff_id,
                        principalTable: "staff",
                        principalColumn: "staff_id");
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_user_staff",
                        column: x => x.user_id,
                        principalTable: "staff",
                        principalColumn: "staff_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_department_director_id",
                table: "department",
                column: "director_id");

            migrationBuilder.CreateIndex(
                name: "IX_staff_department_id",
                table: "staff",
                column: "department_id");

            migrationBuilder.CreateIndex(
                name: "IX_staff_order_order_id",
                table: "staff_order",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_staff_order_staff_id",
                table: "staff_order",
                column: "staff_id");

            migrationBuilder.AddForeignKey(
                name: "FK_department_staff",
                table: "department",
                column: "director_id",
                principalTable: "staff",
                principalColumn: "staff_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_department_staff",
                table: "department");

            migrationBuilder.DropTable(
                name: "staff_order");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "order");

            migrationBuilder.DropTable(
                name: "staff");

            migrationBuilder.DropTable(
                name: "department");
        }
    }
}
