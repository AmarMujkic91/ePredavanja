using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eGostujucaPredavanja.Services.Migrations
{
    /// <inheritdoc />
    public partial class izmjenaNaziva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventSponsors_Events_EventsEventId",
                table: "EventSponsors");

            migrationBuilder.DropForeignKey(
                name: "FK_EventSponsors_Sponsors_SponsorsSponsorId",
                table: "EventSponsors");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionSpeakers_Sessions_SessionsSessionId",
                table: "SessionSpeakers");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionSpeakers_Speakers_SpeakersSpeakerId",
                table: "SessionSpeakers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEvents_Events_EventsEventId",
                table: "UserEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEvents_Users_UsersUserId",
                table: "UserEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPositions_Positions_PositionsPositionId",
                table: "UserPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPositions_Users_UsersUserId",
                table: "UserPositions");

            migrationBuilder.DropIndex(
                name: "IX_UserPositions_PositionsPositionId",
                table: "UserPositions");

            migrationBuilder.DropIndex(
                name: "IX_UserPositions_UsersUserId",
                table: "UserPositions");

            migrationBuilder.DropIndex(
                name: "IX_UserEvents_EventsEventId",
                table: "UserEvents");

            migrationBuilder.DropIndex(
                name: "IX_UserEvents_UsersUserId",
                table: "UserEvents");

            migrationBuilder.DropIndex(
                name: "IX_SessionSpeakers_SessionsSessionId",
                table: "SessionSpeakers");

            migrationBuilder.DropIndex(
                name: "IX_SessionSpeakers_SpeakersSpeakerId",
                table: "SessionSpeakers");

            migrationBuilder.DropIndex(
                name: "IX_EventSponsors_EventsEventId",
                table: "EventSponsors");

            migrationBuilder.DropColumn(
                name: "PositionsPositionId",
                table: "UserPositions");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "UserPositions");

            migrationBuilder.DropColumn(
                name: "EventsEventId",
                table: "UserEvents");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "UserEvents");

            migrationBuilder.DropColumn(
                name: "SessionsSessionId",
                table: "SessionSpeakers");

            migrationBuilder.DropColumn(
                name: "SpeakersSpeakerId",
                table: "SessionSpeakers");

            migrationBuilder.DropColumn(
                name: "EventsEventId",
                table: "EventSponsors");

            migrationBuilder.RenameColumn(
                name: "SponsorsSponsorId",
                table: "EventSponsors",
                newName: "SponsorId");

            migrationBuilder.RenameIndex(
                name: "IX_EventSponsors_SponsorsSponsorId",
                table: "EventSponsors",
                newName: "IX_EventSponsors_SponsorId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPositions_PositionId",
                table: "UserPositions",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPositions_UserId",
                table: "UserPositions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_EventId",
                table: "UserEvents",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_UserId",
                table: "UserEvents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionSpeakers_SessionId",
                table: "SessionSpeakers",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionSpeakers_SpeakerId",
                table: "SessionSpeakers",
                column: "SpeakerId");

            migrationBuilder.CreateIndex(
                name: "IX_EventSponsors_EventId",
                table: "EventSponsors",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventSponsors_Events_EventId",
                table: "EventSponsors",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventSponsors_Sponsors_SponsorId",
                table: "EventSponsors",
                column: "SponsorId",
                principalTable: "Sponsors",
                principalColumn: "SponsorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SessionSpeakers_Sessions_SessionId",
                table: "SessionSpeakers",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "SessionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SessionSpeakers_Speakers_SpeakerId",
                table: "SessionSpeakers",
                column: "SpeakerId",
                principalTable: "Speakers",
                principalColumn: "SpeakerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEvents_Events_EventId",
                table: "UserEvents",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEvents_Users_UserId",
                table: "UserEvents",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPositions_Positions_PositionId",
                table: "UserPositions",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "PositionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPositions_Users_UserId",
                table: "UserPositions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventSponsors_Events_EventId",
                table: "EventSponsors");

            migrationBuilder.DropForeignKey(
                name: "FK_EventSponsors_Sponsors_SponsorId",
                table: "EventSponsors");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionSpeakers_Sessions_SessionId",
                table: "SessionSpeakers");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionSpeakers_Speakers_SpeakerId",
                table: "SessionSpeakers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEvents_Events_EventId",
                table: "UserEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEvents_Users_UserId",
                table: "UserEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPositions_Positions_PositionId",
                table: "UserPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPositions_Users_UserId",
                table: "UserPositions");

            migrationBuilder.DropIndex(
                name: "IX_UserPositions_PositionId",
                table: "UserPositions");

            migrationBuilder.DropIndex(
                name: "IX_UserPositions_UserId",
                table: "UserPositions");

            migrationBuilder.DropIndex(
                name: "IX_UserEvents_EventId",
                table: "UserEvents");

            migrationBuilder.DropIndex(
                name: "IX_UserEvents_UserId",
                table: "UserEvents");

            migrationBuilder.DropIndex(
                name: "IX_SessionSpeakers_SessionId",
                table: "SessionSpeakers");

            migrationBuilder.DropIndex(
                name: "IX_SessionSpeakers_SpeakerId",
                table: "SessionSpeakers");

            migrationBuilder.DropIndex(
                name: "IX_EventSponsors_EventId",
                table: "EventSponsors");

            migrationBuilder.RenameColumn(
                name: "SponsorId",
                table: "EventSponsors",
                newName: "SponsorsSponsorId");

            migrationBuilder.RenameIndex(
                name: "IX_EventSponsors_SponsorId",
                table: "EventSponsors",
                newName: "IX_EventSponsors_SponsorsSponsorId");

            migrationBuilder.AddColumn<int>(
                name: "PositionsPositionId",
                table: "UserPositions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsersUserId",
                table: "UserPositions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EventsEventId",
                table: "UserEvents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsersUserId",
                table: "UserEvents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SessionsSessionId",
                table: "SessionSpeakers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpeakersSpeakerId",
                table: "SessionSpeakers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EventsEventId",
                table: "EventSponsors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserPositions_PositionsPositionId",
                table: "UserPositions",
                column: "PositionsPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPositions_UsersUserId",
                table: "UserPositions",
                column: "UsersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_EventsEventId",
                table: "UserEvents",
                column: "EventsEventId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_UsersUserId",
                table: "UserEvents",
                column: "UsersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionSpeakers_SessionsSessionId",
                table: "SessionSpeakers",
                column: "SessionsSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionSpeakers_SpeakersSpeakerId",
                table: "SessionSpeakers",
                column: "SpeakersSpeakerId");

            migrationBuilder.CreateIndex(
                name: "IX_EventSponsors_EventsEventId",
                table: "EventSponsors",
                column: "EventsEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventSponsors_Events_EventsEventId",
                table: "EventSponsors",
                column: "EventsEventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventSponsors_Sponsors_SponsorsSponsorId",
                table: "EventSponsors",
                column: "SponsorsSponsorId",
                principalTable: "Sponsors",
                principalColumn: "SponsorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SessionSpeakers_Sessions_SessionsSessionId",
                table: "SessionSpeakers",
                column: "SessionsSessionId",
                principalTable: "Sessions",
                principalColumn: "SessionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SessionSpeakers_Speakers_SpeakersSpeakerId",
                table: "SessionSpeakers",
                column: "SpeakersSpeakerId",
                principalTable: "Speakers",
                principalColumn: "SpeakerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEvents_Events_EventsEventId",
                table: "UserEvents",
                column: "EventsEventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEvents_Users_UsersUserId",
                table: "UserEvents",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPositions_Positions_PositionsPositionId",
                table: "UserPositions",
                column: "PositionsPositionId",
                principalTable: "Positions",
                principalColumn: "PositionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPositions_Users_UsersUserId",
                table: "UserPositions",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
