namespace DapperPractice.Model
{
    public class Billing
    {
        /*
         SELECT TOP (1000) [Id]
      ,[Name]
      ,[BillingStartDate]
      ,[IndustryType]
      ,[CustomerSuccessManager]
  FROM [sqldb-kekabiz-analytics].[dbo].[BillingAccount]
        */

        public string Name { get; set; }
        public DateTime BillingStartDate { get; set; }
        public string IndustryType { get; set; }
        public string CustomerSuccessManager { get; set; }

    }
}
