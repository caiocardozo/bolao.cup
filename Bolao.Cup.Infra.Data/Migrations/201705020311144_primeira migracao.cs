namespace Bolao.Cup.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primeiramigracao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aposta",
                c => new
                    {
                        cod_aposta = c.Int(nullable: false, identity: true),
                        cod_user = c.Int(nullable: false),
                        cod_jogo = c.Int(nullable: false),
                        cas_aposta = c.Int(nullable: false),
                        vis_aposta = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cod_aposta)
                .ForeignKey("dbo.Usuario", t => t.cod_user)
                .Index(t => t.cod_user);
            
            CreateTable(
                "dbo.Jogo",
                c => new
                    {
                        cod_jogo = c.Int(nullable: false, identity: true),
                        cod_rodada = c.Int(nullable: false),
                        cas_clube = c.Int(nullable: false),
                        casres_jogo = c.Int(nullable: false),
                        vis_clube = c.Int(nullable: false),
                        visres_jogo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cod_jogo)
                .ForeignKey("dbo.Clube", t => t.cas_clube)
                .ForeignKey("dbo.Clube", t => t.vis_clube)
                .ForeignKey("dbo.Rodada", t => t.cod_rodada)
                .ForeignKey("dbo.Aposta", t => t.cod_jogo)
                .Index(t => t.cod_jogo)
                .Index(t => t.cod_rodada)
                .Index(t => t.cas_clube)
                .Index(t => t.vis_clube);
            
            CreateTable(
                "dbo.Clube",
                c => new
                    {
                        cod_clube = c.Int(nullable: false, identity: true),
                        des_clube = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.cod_clube);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Email = c.String(nullable: false, maxLength: 150, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 100, unicode: false),
                        Status = c.String(nullable: false, maxLength: 7, unicode: false),
                        AlteraSenha = c.String(nullable: false, maxLength: 1, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                        TimeFavorito = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clube", t => t.TimeFavorito)
                .Index(t => t.TimeFavorito);
            
            CreateTable(
                "dbo.Pontuacao",
                c => new
                    {
                        cod_campeonato = c.Int(nullable: false),
                        cod_user = c.Int(nullable: false),
                        pos_atual = c.Int(nullable: false),
                        pos_anterior = c.Int(nullable: false),
                        pos_pontuacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.cod_campeonato, t.cod_user })
                .ForeignKey("dbo.Campeonato", t => t.cod_campeonato)
                .ForeignKey("dbo.Usuario", t => t.cod_user)
                .Index(t => t.cod_campeonato)
                .Index(t => t.cod_user);
            
            CreateTable(
                "dbo.Campeonato",
                c => new
                    {
                        cod_campeonato = c.Int(nullable: false, identity: true),
                        nom_campeonato = c.String(nullable: false, maxLength: 100, unicode: false),
                        ini_campeonato = c.DateTime(nullable: false),
                        fim_campeonato = c.DateTime(nullable: false),
                        sit_campeonato = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.cod_campeonato);
            
            CreateTable(
                "dbo.Rodada",
                c => new
                    {
                        cod_rodada = c.Int(nullable: false, identity: true),
                        des_rodada = c.String(nullable: false, maxLength: 100, unicode: false),
                        peso_rodada = c.Int(nullable: false),
                        cod_campeonato = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cod_rodada)
                .ForeignKey("dbo.Campeonato", t => t.cod_campeonato)
                .Index(t => t.cod_campeonato);
            
            CreateTable(
                "dbo.Pontuacao_Rodada",
                c => new
                    {
                        cod_rodada = c.Int(nullable: false),
                        cod_user = c.Int(nullable: false),
                        pos_atual = c.Int(nullable: false),
                        pos_anterior = c.Int(nullable: false),
                        pontuacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.cod_rodada, t.cod_user })
                .ForeignKey("dbo.Rodada", t => t.cod_rodada)
                .ForeignKey("dbo.Usuario", t => t.cod_user)
                .Index(t => t.cod_rodada)
                .Index(t => t.cod_user);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Aposta", "cod_user", "dbo.Usuario");
            DropForeignKey("dbo.Jogo", "cod_jogo", "dbo.Aposta");
            DropForeignKey("dbo.Jogo", "cod_rodada", "dbo.Rodada");
            DropForeignKey("dbo.Jogo", "vis_clube", "dbo.Clube");
            DropForeignKey("dbo.Jogo", "cas_clube", "dbo.Clube");
            DropForeignKey("dbo.Pontuacao", "cod_user", "dbo.Usuario");
            DropForeignKey("dbo.Pontuacao", "cod_campeonato", "dbo.Campeonato");
            DropForeignKey("dbo.Pontuacao_Rodada", "cod_user", "dbo.Usuario");
            DropForeignKey("dbo.Pontuacao_Rodada", "cod_rodada", "dbo.Rodada");
            DropForeignKey("dbo.Rodada", "cod_campeonato", "dbo.Campeonato");
            DropForeignKey("dbo.Usuario", "TimeFavorito", "dbo.Clube");
            DropIndex("dbo.Pontuacao_Rodada", new[] { "cod_user" });
            DropIndex("dbo.Pontuacao_Rodada", new[] { "cod_rodada" });
            DropIndex("dbo.Rodada", new[] { "cod_campeonato" });
            DropIndex("dbo.Pontuacao", new[] { "cod_user" });
            DropIndex("dbo.Pontuacao", new[] { "cod_campeonato" });
            DropIndex("dbo.Usuario", new[] { "TimeFavorito" });
            DropIndex("dbo.Jogo", new[] { "vis_clube" });
            DropIndex("dbo.Jogo", new[] { "cas_clube" });
            DropIndex("dbo.Jogo", new[] { "cod_rodada" });
            DropIndex("dbo.Jogo", new[] { "cod_jogo" });
            DropIndex("dbo.Aposta", new[] { "cod_user" });
            DropTable("dbo.Pontuacao_Rodada");
            DropTable("dbo.Rodada");
            DropTable("dbo.Campeonato");
            DropTable("dbo.Pontuacao");
            DropTable("dbo.Usuario");
            DropTable("dbo.Clube");
            DropTable("dbo.Jogo");
            DropTable("dbo.Aposta");
        }
    }
}
