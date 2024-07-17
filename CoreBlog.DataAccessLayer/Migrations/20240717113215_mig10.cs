using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreBlog.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MessageID",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Receiver = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_MessageID",
                table: "Blogs",
                column: "MessageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Messages_MessageID",
                table: "Blogs",
                column: "MessageID",
                principalTable: "Messages",
                principalColumn: "MessageID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Messages_MessageID",
                table: "Blogs");

            migrationBuilder.DropTable( 
                name: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_MessageID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "MessageID",
                table: "Blogs");
        }
    }
}
