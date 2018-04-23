using System.Data.Entity.ModelConfiguration;
using Vendas.WebApi.Models;

namespace Vendas.WebApi.Mapping
{
    public class VendedorMap : EntityTypeConfiguration<Vendedor>
    {
        //Configurações da tabela
        public VendedorMap()
        {
            //Nome
            ToTable("Vendedor");

            //Chave Primária
            HasKey(v => v.Id);

            //Propriedades
            Property(v => v.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            //Relacionamento com Venda
            HasRequired(p => p.Venda)
                .WithRequiredPrincipal(vd => vd.Vendedor);
        }
    }
}