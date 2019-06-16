namespace MyShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Warranty", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Tags", c => c.String());
            AddColumn("dbo.Products", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "OriginalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProductCategories", "HomeFlag", c => c.Boolean());
            DropColumn("dbo.Products", "Waranty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Waranty", c => c.Int(nullable: false));
            AlterColumn("dbo.ProductCategories", "HomeFlag", c => c.Int());
            DropColumn("dbo.Products", "OriginalPrice");
            DropColumn("dbo.Products", "Quantity");
            DropColumn("dbo.Products", "Tags");
            DropColumn("dbo.Products", "Warranty");
        }
    }
}
