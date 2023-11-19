﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AREA_ReST_API.Migrations
{
    /// <inheritdoc />
    public partial class add_conenction_link_in_services : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConnectionLink",
                table: "Services",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConnectionLink",
                table: "Services");
        }
    }
}
