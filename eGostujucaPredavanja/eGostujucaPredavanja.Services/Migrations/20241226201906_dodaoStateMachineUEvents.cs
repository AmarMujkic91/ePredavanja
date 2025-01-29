using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eGostujucaPredavanja.Services.Migrations
{
    /// <inheritdoc />
    public partial class dodaoStateMachineUEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StateMachine",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StateMachine",
                table: "Events");
        }
    }
}
