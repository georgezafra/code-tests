namespace EmployeeCostCalculator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Dependents", "CostOfBenefits", c => c.Double(nullable: false));
            AlterColumn("dbo.Employees", "CostofBenefits", c => c.Double(nullable: false));
            AlterColumn("dbo.Employees", "TotalCostOfBenefits", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "TotalCostOfBenefits", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "CostofBenefits", c => c.Int(nullable: false));
            AlterColumn("dbo.Dependents", "CostOfBenefits", c => c.Int(nullable: false));
        }
    }
}
