using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studentschool.Migrations
{
    /// <inheritdoc />
    public partial class mgs2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Schools_SchoolId",
                table: "Classes");

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                column: "SchoolId",
                value: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Schools_SchoolId",
                table: "Classes",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Schools_SchoolId",
                table: "Classes");

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "Classes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                column: "SchoolId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Schools_SchoolId",
                table: "Classes",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id");
        }
    }
}
