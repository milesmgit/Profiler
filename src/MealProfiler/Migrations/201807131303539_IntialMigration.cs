namespace MealProfiler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        ProfileId = c.Int(nullable: false, identity: true),
                        MealGoal = c.Int(nullable: false),
                        PrepTime = c.Int(nullable: false),
                        MealCost = c.Double(nullable: false),
                        MealAuthor = c.String(),
                        SpinachCheckbox = c.Boolean(nullable: false),
                        TomatoCheckbox = c.Boolean(nullable: false),
                        SpinachQuantity = c.Double(),
                        TomatoQuantity = c.Double(),
                        Notes = c.String(maxLength: 200),
                        Meal_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ProfileId)
                .ForeignKey("dbo.Meals", t => t.Meal_Id)
                .Index(t => t.Meal_Id);
            
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profiles", "Meal_Id", "dbo.Meals");
            DropIndex("dbo.Profiles", new[] { "Meal_Id" });
            DropTable("dbo.Meals");
            DropTable("dbo.Profiles");
        }
    }
}
