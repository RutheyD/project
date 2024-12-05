using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class createDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookList",
                columns: table => new
                {
                    IdBook = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBorrowing = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookList", x => x.IdBook);
                });

            migrationBuilder.CreateTable(
                name: "SubscribeList",
                columns: table => new
                {
                    IdSubscribe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscribeList", x => x.IdSubscribe);
                });

            migrationBuilder.CreateTable(
                name: "BorrowList",
                columns: table => new
                {
                    IdBorrow = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BorrowDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubscriberIdSubscribe = table.Column<int>(type: "int", nullable: true),
                    BorrowedBookIdBook = table.Column<int>(type: "int", nullable: true),
                    IsReturned = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowList", x => x.IdBorrow);
                    table.ForeignKey(
                        name: "FK_BorrowList_BookList_BorrowedBookIdBook",
                        column: x => x.BorrowedBookIdBook,
                        principalTable: "BookList",
                        principalColumn: "IdBook");
                    table.ForeignKey(
                        name: "FK_BorrowList_SubscribeList_SubscriberIdSubscribe",
                        column: x => x.SubscriberIdSubscribe,
                        principalTable: "SubscribeList",
                        principalColumn: "IdSubscribe");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BorrowList_BorrowedBookIdBook",
                table: "BorrowList",
                column: "BorrowedBookIdBook");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowList_SubscriberIdSubscribe",
                table: "BorrowList",
                column: "SubscriberIdSubscribe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BorrowList");

            migrationBuilder.DropTable(
                name: "BookList");

            migrationBuilder.DropTable(
                name: "SubscribeList");
        }
    }
}
