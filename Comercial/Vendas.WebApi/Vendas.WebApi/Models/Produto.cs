namespace Vendas.WebApi.Models
{
    public class Produto
    {
        //Inicia lista de venda
        public Produto()
        {
            Venda = new Venda();
        }

        //Características do produto
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        //Relacionamento com Venda
        public virtual Venda Venda { get; set; }
    }
}