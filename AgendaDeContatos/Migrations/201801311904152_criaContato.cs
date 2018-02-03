namespace AgendaDeContatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criaContato : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contatoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        cpf = c.Long(nullable: false),
                        rg = c.Int(nullable: false),
                        telefone1 = c.Long(nullable: false),
                        cep = c.Int(nullable: false),
                        logradouro = c.String(),
                        numero = c.Int(nullable: false),
                        bairro = c.String(),
                        municipio = c.String(),
                        uf = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contatoes");
        }
    }
}
