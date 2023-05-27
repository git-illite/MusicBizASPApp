namespace F2022A6AA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedTracksWithMediaItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tracks", "MediaContentType", c => c.String(maxLength: 200));
            AddColumn("dbo.Tracks", "Media", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tracks", "Media");
            DropColumn("dbo.Tracks", "MediaContentType");
        }
    }
}
