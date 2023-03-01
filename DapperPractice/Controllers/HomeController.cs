using Dapper;
using DapperPractice.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace DapperPractice.Controllers
{
    public class HomeController : Controller
    {
        private const string ConnectionString = "Server=sqldev;DataBase=sqldb-kekabiz-analytics;User Id=dev;Password=E0xl8T0RoqPs$vE3;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true;Integrated Security=false;";

        [HttpGet("GetBillingData")]
        public async Task<IActionResult> Index()
        {
            var sql = @"SELECT
                       [Name]
                      ,[BillingStartDate]
                      ,[IndustryType]
                      ,[CustomerSuccessManager]
                       FROM[sqldb-kekabiz-analytics].[dbo].[BillingAccount]
                       WHERE Name = @name"
                    ;

            using (var connection = new SqlConnection(ConnectionString))
            {
                var bill = await connection.QueryAsync<Billing>(sql,new {name = "Trinath" });
                return Ok(bill);
            }
            
        }
    }
}
