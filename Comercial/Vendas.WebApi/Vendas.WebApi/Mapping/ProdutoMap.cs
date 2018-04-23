using System.Data.Entity.ModelConfiguration;
using Vendas.WebApi.Models;

namespace Vendas.WebApi.Mapping
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        //Propriedades da tabela
        public ProdutoMap()
        {
            //Nome
            ToTable("Produto");

            //Chave Primária
            HasKey(p => p.Id);

            //Propriedades
            Property(p => p.Descricao)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            Property(p => p.Preco)
                .HasPrecision(18,2)
                .HasColumnType("decimal");

            //Relacionamento com Venda
            HasRequired(p => p.Venda)
                .WithRequiredPrincipal(vd => vd.Produto);

        }
    }
}