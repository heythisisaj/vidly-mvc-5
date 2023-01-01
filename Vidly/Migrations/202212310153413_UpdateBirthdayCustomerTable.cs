namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthdayCustomerTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '10-26-87' WHERE Id = 1");
            Sql("UPDATE Customers SET Birthdate = '10-27-87' WHERE Id = 2");
            Sql("UPDATE Customers SET Birthdate = '10-28-87' WHERE Id = 3");
        
        }
        
        public override void Down()
        {
        }
    }
}
