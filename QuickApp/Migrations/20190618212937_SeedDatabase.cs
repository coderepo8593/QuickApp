using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickApp.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO AppCarMake (Name) VALUES ('Make1')");
            migrationBuilder.Sql("INSERT INTO AppCarMake (Name) VALUES ('Make2')");
            migrationBuilder.Sql("INSERT INTO AppCarMake (Name) VALUES ('Make3')");

            migrationBuilder.Sql("INSERT INTO AppCarModel (Name, CarMakeId) VALUES ('Make1-ModelA', (SELECT Id FROM AppCarMake WHERE Name = 'Make1'))");
            migrationBuilder.Sql("INSERT INTO AppCarModel (Name, CarMakeId) VALUES ('Make1-ModelB', (SELECT Id FROM AppCarMake WHERE Name = 'Make1'))");
            migrationBuilder.Sql("INSERT INTO AppCarModel (Name, CarMakeId) VALUES ('Make1-ModelC', (SELECT Id FROM AppCarMake WHERE Name = 'Make1'))");

            migrationBuilder.Sql("INSERT INTO AppCarModel (Name, CarMakeId) VALUES ('Make2-ModelA', (SELECT Id FROM AppCarMake WHERE Name = 'Make2'))");
            migrationBuilder.Sql("INSERT INTO AppCarModel (Name, CarMakeId) VALUES ('Make2-ModelB', (SELECT Id FROM AppCarMake WHERE Name = 'Make2'))");
            migrationBuilder.Sql("INSERT INTO AppCarModel (Name, CarMakeId) VALUES ('Make2-ModelC', (SELECT Id FROM AppCarMake WHERE Name = 'Make2'))");

            migrationBuilder.Sql("INSERT INTO AppCarModel (Name, CarMakeId) VALUES ('Make3-ModelA', (SELECT Id FROM AppCarMake WHERE Name = 'Make3'))");
            migrationBuilder.Sql("INSERT INTO AppCarModel (Name, CarMakeId) VALUES ('Make3-ModelB', (SELECT Id FROM AppCarMake WHERE Name = 'Make3'))");
            migrationBuilder.Sql("INSERT INTO AppCarModel (Name, CarMakeId) VALUES ('Make3-ModelC', (SELECT Id FROM AppCarMake WHERE Name = 'Make3'))");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM AppCarMake WHERE Name IN ('Make1', 'Make2', 'Make3')");
        }
    }
}
