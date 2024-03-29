﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Migrators.PostgreSQL.Migrations.Application
{
    public partial class UpdatedRoleClaims : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "Identity",
                table: "RoleClaims",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                schema: "Identity",
                table: "RoleClaims",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Group",
                schema: "Identity",
                table: "RoleClaims",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                schema: "Identity",
                table: "RoleClaims",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                schema: "Identity",
                table: "RoleClaims",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoleId1",
                schema: "Identity",
                table: "RoleClaims",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId1",
                schema: "Identity",
                table: "RoleClaims",
                column: "RoleId1");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Roles_RoleId1",
                schema: "Identity",
                table: "RoleClaims",
                column: "RoleId1",
                principalSchema: "Identity",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Roles_RoleId1",
                schema: "Identity",
                table: "RoleClaims");

            migrationBuilder.DropIndex(
                name: "IX_RoleClaims_RoleId1",
                schema: "Identity",
                table: "RoleClaims");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "Identity",
                table: "RoleClaims");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                schema: "Identity",
                table: "RoleClaims");

            migrationBuilder.DropColumn(
                name: "Group",
                schema: "Identity",
                table: "RoleClaims");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                schema: "Identity",
                table: "RoleClaims");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                schema: "Identity",
                table: "RoleClaims");

            migrationBuilder.DropColumn(
                name: "RoleId1",
                schema: "Identity",
                table: "RoleClaims");
        }
    }
}
