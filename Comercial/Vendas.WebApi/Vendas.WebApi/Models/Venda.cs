using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vendas.WebApi.Models
{
    public class Venda
    {
        //Características da venda
        public int Id { get; set; }
        public decimal Comissao { get; set; }
        public DateTime DataVenda { get; set; }

        //Chaves estrangeiras
        public int ProdutoId { get; set; }
        public int VendedorId { get; set; }

        //Propriedades de navegação
        public virtual Produto Produto { get; set; }
        public virtual Vendedor Vendedor { get; set; }
    }
}