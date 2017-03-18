namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into MembershipTypes(Id,SignUpFree,DurationTime,DiscountRate)Values(1,0,0,0)");
            Sql("Insert into MembershipTypes(Id,SignUpFree,DurationTime,DiscountRate)Values(2,100,1,10)");
            Sql("Insert into MembershipTypes(Id,SignUpFree,DurationTime,DiscountRate)Values(3,200,3,15)");
            Sql("Insert into MembershipTypes(Id,SignUpFree,DurationTime,DiscountRate)Values(4,500,6,20)");
        }
        
        public override void Down()
        {
        }
    }
}
