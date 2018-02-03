namespace AgendaDeContatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criaContato2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Contatoes", "cep");
            DropColumn("dbo.Contatoes", "logradouro");
            DropColumn("dbo.Contatoes", "numero");
            DropColumn("dbo.Contatoes", "bairro");
            DropColumn("dbo.Contatoes", "municipio");
            DropColumn("dbo.Contatoes", "uf");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contatoes", "uf", c => c.String());
            AddColumn("dbo.Contatoes", "municipio", c => c.String());
            AddColumn("dbo.Contatoes", "bairro", c => c.String());
            AddColumn("dbo.Contatoes", "numero", c => c.Int(nullable: false));
            AddColumn("dbo.Contatoes", "logradouro", c => c.String());
            AddColumn("dbo.Contatoes", "cep", c => c.Int(nullable: false));
        }
    }
}
