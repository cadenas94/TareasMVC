using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF NOT EXISTS(Select Id FROM AspNetRoles WHERE Id = 'a3a02d289be5441281cf73887958387a')
                                    BEGIN
	                                    INSERT AspNetRoles (Id, [Name], [NormalizedName])
	                                    VALUES ('a3a02d289be5441281cf73887958387a','admin','ADMIN')
                                    END");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE AspNetRoles WHERE Id = 'a3a02d289be5441281cf73887958387a'");
        }
    }
}
