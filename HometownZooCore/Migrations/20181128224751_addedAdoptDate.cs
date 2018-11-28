﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HometownZooCore.Migrations
{
    public partial class addedAdoptDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AdoptionDate",
                table: "Animal",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdoptionDate",
                table: "Animal");
        }
    }
}
