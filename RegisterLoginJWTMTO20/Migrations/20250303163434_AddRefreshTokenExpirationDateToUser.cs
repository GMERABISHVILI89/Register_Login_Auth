using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegisterLoginJWTMTO20.Migrations
{
    /// <inheritdoc />
    public partial class AddRefreshTokenExpirationDateToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpirationDate",
                table: "Users",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshTokenExpirationDate",
                table: "Users");
        }
    }
}
