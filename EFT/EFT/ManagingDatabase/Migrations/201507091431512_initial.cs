namespace ManagingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AlbumDetails", "Album_AlbumId", "dbo.Album Info");
            RenameColumn(table: "dbo.AlbumDetails", name: "Album_AlbumId", newName: "Album_AId");
            RenameIndex(table: "dbo.AlbumDetails", name: "IX_Album_AlbumId", newName: "IX_Album_AId");
            DropPrimaryKey("dbo.Album Info");
            AddColumn("dbo.Album Info", "AId", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Album Info", "AId");
            AddForeignKey("dbo.AlbumDetails", "Album_AId", "dbo.Album Info", "AId");
            DropColumn("dbo.Album Info", "AlbumId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Album Info", "AlbumId", c => c.Guid(nullable: false));
            DropForeignKey("dbo.AlbumDetails", "Album_AId", "dbo.Album Info");
            DropPrimaryKey("dbo.Album Info");
            DropColumn("dbo.Album Info", "AId");
            AddPrimaryKey("dbo.Album Info", "AlbumId");
            RenameIndex(table: "dbo.AlbumDetails", name: "IX_Album_AId", newName: "IX_Album_AlbumId");
            RenameColumn(table: "dbo.AlbumDetails", name: "Album_AId", newName: "Album_AlbumId");
            AddForeignKey("dbo.AlbumDetails", "Album_AlbumId", "dbo.Album Info", "AlbumId");
        }
    }
}
