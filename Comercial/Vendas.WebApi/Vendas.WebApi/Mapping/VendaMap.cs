using System.Data.Entity.ModelConfiguration;
using Vendas.WebApi.Models;

namespace Vendas.WebApi.Mapping
{
    public class VendaMap : EntityTypeConfiguration<Venda>
    {
        //Configurações da tabela
        public VendaMap()
        {
            //Nome
            ToTable("Venda");

            //Chave Primária
            HasKey(v => v.Id);

            //Propriedades
            Property(v => v.Comissao)
                .HasPrecision(18, 2)
                .HasColumnType("decimal");
            Property(v => v.DataVenda)
                .HasColumnType("datetime");
        }
    }
}