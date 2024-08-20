using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class AddingRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stud_ID",
                table: "Stud_Course",
                newName: "stud_ID");

            migrationBuilder.RenameColumn(
                name: "Inst_ID",
                table: "Course_Inst",
                newName: "inst_ID");

            migrationBuilder.AddColumn<int>(
                name: "Stud_ID",
                table: "Stud_Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dept_ID",
                table: "Instructor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "HiringDate",
                table: "Department",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "Inst_ID",
                table: "Course_Inst",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Course",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<double>(
                name: "Duration",
                table: "Course",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Course",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "3, 30")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course",
                columns: new[] { "Stud_ID", "Course_ID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst",
                columns: new[] { "Course_ID", "Inst_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_Student_Dep_Id",
                table: "Student",
                column: "Dep_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Course_Course_ID",
                table: "Stud_Course",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Course_stud_ID",
                table: "Stud_Course",
                column: "stud_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_Dept_ID",
                table: "Instructor",
                column: "Dept_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_Ins_ID",
                table: "Department",
                column: "Ins_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Course_Inst_inst_ID",
                table: "Course_Inst",
                column: "inst_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Top_ID",
                table: "Course",
                column: "Top_ID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Topic_Top_ID",
                table: "Course",
                column: "Top_ID",
                principalTable: "Topic",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Course_Course_ID",
                table: "Course_Inst",
                column: "Course_ID",
                principalTable: "Course",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Instructor_inst_ID",
                table: "Course_Inst",
                column: "inst_ID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructor_Ins_ID",
                table: "Department",
                column: "Ins_ID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Department_Dept_ID",
                table: "Instructor",
                column: "Dept_ID",
                principalTable: "Department",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Course_Course_ID",
                table: "Stud_Course",
                column: "Course_ID",
                principalTable: "Course",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Student_stud_ID",
                table: "Stud_Course",
                column: "stud_ID",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Department_Dep_Id",
                table: "Student",
                column: "Dep_Id",
                principalTable: "Department",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Topic_Top_ID",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Course_Course_ID",
                table: "Course_Inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Instructor_inst_ID",
                table: "Course_Inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_Instructor_Ins_ID",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Department_Dept_ID",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Course_Course_ID",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Student_stud_ID",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Department_Dep_Id",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_Dep_Id",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Course_Course_ID",
                table: "Stud_Course");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Course_stud_ID",
                table: "Stud_Course");

            migrationBuilder.DropIndex(
                name: "IX_Instructor_Dept_ID",
                table: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Department_Ins_ID",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst");

            migrationBuilder.DropIndex(
                name: "IX_Course_Inst_inst_ID",
                table: "Course_Inst");

            migrationBuilder.DropIndex(
                name: "IX_Course_Top_ID",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "Stud_ID",
                table: "Stud_Course");

            migrationBuilder.DropColumn(
                name: "Dept_ID",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "Inst_ID",
                table: "Course_Inst");

            migrationBuilder.RenameColumn(
                name: "stud_ID",
                table: "Stud_Course",
                newName: "Stud_ID");

            migrationBuilder.RenameColumn(
                name: "inst_ID",
                table: "Course_Inst",
                newName: "Inst_ID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HiringDate",
                table: "Department",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Course",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Course",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "3, 30");
        }
    }
}
