namespace Vendas.WebApi.Models
{
    public class Vendedor
    {
        //Instancia objeto
        public Vendedor()
        {
            Venda = new Venda();
        }

        //Características do vendedor
        public int Id { get; set; }
        public string Nome { get; set; }

        //Relacionamento com Venda
        public virtual Venda Venda { get; set; }
    }
}