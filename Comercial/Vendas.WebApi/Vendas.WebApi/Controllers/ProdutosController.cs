using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Vendas.WebApi.DataContexts;
using Vendas.WebApi.Models;

namespace Vendas.WebApi.Controllers
{
    public class ProdutosController : ApiController
    {
        private VendaDataContexts db = new VendaDataContexts();

        //Método http para consulta
        public List<Produto> Get()
        {
            return db.Produtos.ToList();
        }

        //Método http para inclusão
        public void Post(Produto produto)
        {
            if (produto.Id > 0)
            {
                db.Produtos.Add(produto);
                db.SaveChanges();
            }
        }

        //Método http para edição
        public void Put(Produto produto)
        {
            if (produto.Id > 0)
            {
                db.Produtos.Add(produto);
                db.SaveChanges();
            }
        }

        //Método http para remoção
        public void Delete(int id)
        {
            if (id > 0)
            {
                Produto produto = db.Produtos.Find(id);
                db.Produtos.Remove(produto);
                db.SaveChanges();
            }
        }
    }
}
