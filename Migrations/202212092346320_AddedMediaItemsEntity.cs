namespace F2022A6AA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMediaItemsEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MediaItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Caption = c.String(nullable: false),
                        Content = c.Binary(),
                        ContentType = c.String(),
                        StringId = c.String(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        Artist_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Artists", t => t.Artist_Id)
                .Index(t => t.Artist_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MediaItems", "Artist_Id", "dbo.Artists");
            DropIndex("dbo.MediaItems", new[] { "Artist_Id" });
            DropTable("dbo.MediaItems");
        }
    }
}
