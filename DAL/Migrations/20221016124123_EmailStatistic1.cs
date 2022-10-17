using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class EmailStatistic1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailStatistic_Participants_ToUserId",
                table: "EmailStatistic");

            migrationBuilder.DropIndex(
                name: "IX_EmailStatistic_ToUserId",
                table: "EmailStatistic");

            migrationBuilder.AddColumn<int>(
                name: "ParticipantId",
                table: "EmailStatistic",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmailStatistic_ParticipantId",
                table: "EmailStatistic",
                column: "ParticipantId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailStatistic_Participants_ParticipantId",
                table: "EmailStatistic",
                column: "ParticipantId",
                principalTable: "Participants",
                principalColumn: "ParticipantId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailStatistic_Participants_ParticipantId",
                table: "EmailStatistic");

            migrationBuilder.DropIndex(
                name: "IX_EmailStatistic_ParticipantId",
                table: "EmailStatistic");

            migrationBuilder.DropColumn(
                name: "ParticipantId",
                table: "EmailStatistic");

            migrationBuilder.CreateIndex(
                name: "IX_EmailStatistic_ToUserId",
                table: "EmailStatistic",
                column: "ToUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailStatistic_Participants_ToUserId",
                table: "EmailStatistic",
                column: "ToUserId",
                principalTable: "Participants",
                principalColumn: "ParticipantId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
