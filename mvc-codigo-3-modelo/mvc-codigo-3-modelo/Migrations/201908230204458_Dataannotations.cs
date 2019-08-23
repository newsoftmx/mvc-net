namespace mvc_codigo_3_modelo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dataannotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "nombre", c => c.String(maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "nombre", c => c.String());
        }
    }
}
