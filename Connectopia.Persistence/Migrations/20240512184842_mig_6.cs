﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Connectopia.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_Endpoints_EndpointId",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_EndpointId",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "EndpointId",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "AppRoleEndpoint",
                columns: table => new
                {
                    EndpointsId = table.Column<int>(type: "integer", nullable: false),
                    RolesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleEndpoint", x => new { x.EndpointsId, x.RolesId });
                    table.ForeignKey(
                        name: "FK_AppRoleEndpoint_AspNetRoles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppRoleEndpoint_Endpoints_EndpointsId",
                        column: x => x.EndpointsId,
                        principalTable: "Endpoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppRoleEndpoint_RolesId",
                table: "AppRoleEndpoint",
                column: "RolesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoleEndpoint");

            migrationBuilder.AddColumn<int>(
                name: "EndpointId",
                table: "AspNetRoles",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_EndpointId",
                table: "AspNetRoles",
                column: "EndpointId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_Endpoints_EndpointId",
                table: "AspNetRoles",
                column: "EndpointId",
                principalTable: "Endpoints",
                principalColumn: "Id");
        }
    }
}
