namespace LAEQ.DataContexts.LibraryMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        NamePT = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        Contact = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionID = c.Int(nullable: false, identity: true),
                        MachineID = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        RentalPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Machines", t => t.MachineID, cascadeDelete: true)
                .Index(t => t.MachineID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Machines",
                c => new
                    {
                        MachineID = c.Int(nullable: false, identity: true),
                        SerialNumber = c.String(),
                        MachineNumber = c.String(),
                        Brand = c.String(),
                        Model = c.String(),
                        Year = c.DateTime(nullable: false),
                        Capacity = c.Int(nullable: false),
                        CalibrationDate = c.DateTime(nullable: false),
                        PMDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MachineID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "MachineID", "dbo.Machines");
            DropForeignKey("dbo.Transactions", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Transactions", new[] { "CustomerID" });
            DropIndex("dbo.Transactions", new[] { "MachineID" });
            DropTable("dbo.Machines");
            DropTable("dbo.Transactions");
            DropTable("dbo.Customers");
        }
    }
}
