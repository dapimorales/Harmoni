using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Harmoni.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExchangeDate",
                table: "Exchange",
                newName: "ExchangedDate");

            migrationBuilder.AddColumn<decimal>(
                name: "AdminFee",
                table: "Loans",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "Loans",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovedOn",
                table: "Loans",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Loans",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DueDate",
                table: "Loans",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Fine",
                table: "Loans",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Interest",
                table: "Loans",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "InterestFine",
                table: "Loans",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Loans",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "KkPath",
                table: "Loans",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KtpPath",
                table: "Loans",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LoanId",
                table: "Loans",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Outstanding",
                table: "Loans",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "SlipGajiPath",
                table: "Loans",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Loans",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Tenor",
                table: "Loans",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "TenorLeft",
                table: "Loans",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "Loans",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminFee",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "ApprovedOn",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "Fine",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "Interest",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "InterestFine",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "KkPath",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "KtpPath",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "LoanId",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "Outstanding",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "SlipGajiPath",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "Tenor",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "TenorLeft",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Loans");

            migrationBuilder.RenameColumn(
                name: "ExchangedDate",
                table: "Exchange",
                newName: "ExchangeDate");
        }
    }
}
