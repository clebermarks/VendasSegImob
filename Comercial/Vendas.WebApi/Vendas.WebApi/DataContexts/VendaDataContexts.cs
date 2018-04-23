using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Vendas.WebApi.Mapping;
using Vendas.WebApi.Models;

namespace Vendas.WebApi.DataContexts
{
    public class VendaDataContexts : DbContext
    {
        //Construtor para inicialização e conexão ao banco de dados
        public VendaDataContexts() : base("VendasCS") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Remoção da convenção de pluralização de nomes de tabelas em inglês
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Configuração das Entidades
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new VendaMap());
            modelBuilder.Configurations.Add(new VendedorMap());

            base.OnModelCreating(modelBuilder);
        }

        //Mapeamento das tabelas do banco de dados nas entidades POCO
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
    }
}