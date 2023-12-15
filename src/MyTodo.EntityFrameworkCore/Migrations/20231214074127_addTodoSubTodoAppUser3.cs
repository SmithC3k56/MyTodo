using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyTodo.Migrations
{
    /// <inheritdoc />
    public partial class addTodoSubTodoAppUser3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserTodo");

            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId",
                table: "AppTodos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppTodos_AppUserId",
                table: "AppTodos",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppTodos_AppAppUsers_AppUserId",
                table: "AppTodos",
                column: "AppUserId",
                principalTable: "AppAppUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppTodos_AppAppUsers_AppUserId",
                table: "AppTodos");

            migrationBuilder.DropIndex(
                name: "IX_AppTodos_AppUserId",
                table: "AppTodos");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "AppTodos");

            migrationBuilder.CreateTable(
                name: "AppUserTodo",
                columns: table => new
                {
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    todosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTodo", x => new { x.UsersId, x.todosId });
                    table.ForeignKey(
                        name: "FK_AppUserTodo_AppAppUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AppAppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserTodo_AppTodos_todosId",
                        column: x => x.todosId,
                        principalTable: "AppTodos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserTodo_todosId",
                table: "AppUserTodo",
                column: "todosId");
        }
    }
}
