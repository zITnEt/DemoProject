using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Debts_DebtId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_DebtId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DebtId",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DebtId",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_DebtId",
                table: "Users",
                column: "DebtId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Debts_DebtId",
                table: "Users",
                column: "DebtId",
                principalTable: "Debts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
