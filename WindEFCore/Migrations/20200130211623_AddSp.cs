using Microsoft.EntityFrameworkCore.Migrations;

namespace WindEFCore.Migrations
{
    public partial class AddSp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF OBJECT_ID('usp_clientCount','P') IS NOT NULL
                                    DROP PROCEDURE [dbo].usp_clientCount
                                    GO
                                    CREATE PROCEDURE [dbo].usp_clientCount
                                    AS
                                    BEGIN
	                                    SET NOCOUNT ON;
	                                    
	                                    SELECT 
		                                    c.CompanyName, 
		                                    COUNT(o.OrderId) AS Cnt
	                                    FROM Companies AS c
		                                    JOIN Orders AS o ON o.ClientId = c.CompanyId
	                                    GROUP BY c.CompanyName
	                                    
                                    END
                                    GO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF OBJECT_ID('usp_clientCount','P') IS NOT NULL
                                    DROP PROCEDURE [dbo].usp_clientCount
                                    GO");
        }
    }
}
