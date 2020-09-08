using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_V17.Data.Migrations
{
    public partial class ApplicationDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Department",
                table: "FSApp",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<bool>(
                name: "FCS",
                table: "FSApp",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "InnovationandResearch",
                table: "FSApp",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Online",
                table: "FSApp",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PresidentsOffice",
                table: "FSApp",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Registrars",
                table: "FSApp",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SchoolofBusiness",
                table: "FSApp",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SchoolofEngineering",
                table: "FSApp",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SchoolofScience",
                table: "FSApp",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartmentName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropColumn(
                name: "FCS",
                table: "FSApp");

            migrationBuilder.DropColumn(
                name: "InnovationandResearch",
                table: "FSApp");

            migrationBuilder.DropColumn(
                name: "Online",
                table: "FSApp");

            migrationBuilder.DropColumn(
                name: "PresidentsOffice",
                table: "FSApp");

            migrationBuilder.DropColumn(
                name: "Registrars",
                table: "FSApp");

            migrationBuilder.DropColumn(
                name: "SchoolofBusiness",
                table: "FSApp");

            migrationBuilder.DropColumn(
                name: "SchoolofEngineering",
                table: "FSApp");

            migrationBuilder.DropColumn(
                name: "SchoolofScience",
                table: "FSApp");

            migrationBuilder.AlterColumn<string>(
                name: "Department",
                table: "FSApp",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
