using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KODCoursesAPI.Migrations
{
    /// <inheritdoc />
    public partial class Change_Some_Properties_To_Nullable_Or_With_Initialization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppLessons_AppCourses_CourseId",
                table: "AppLessons");

            migrationBuilder.AlterColumn<Guid>(
                name: "CourseId",
                table: "AppLessons",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_AppLessons_AppCourses_CourseId",
                table: "AppLessons",
                column: "CourseId",
                principalTable: "AppCourses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppLessons_AppCourses_CourseId",
                table: "AppLessons");

            migrationBuilder.AlterColumn<Guid>(
                name: "CourseId",
                table: "AppLessons",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppLessons_AppCourses_CourseId",
                table: "AppLessons",
                column: "CourseId",
                principalTable: "AppCourses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
