using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Vendas.WebApi.DataContexts;
using Vendas.WebApi.Models;

namespace Vendas.WebApi.Controllers
{
    public class VendasController : ApiController
    {
        private VendaDataContexts db = new VendaDataContexts();

        //Método http para consulta
        public List<Venda> Get()
        {
            return db.Vendas.ToList();
        }

        //Método http para inclusão
        public void Post(Venda Venda)
        {
            if (Venda.Id > 0)
            {
                db.Vendas.Add(Venda);
                db.SaveChanges();
            }
        }

        //Método http para edição
        public void Put(Venda Venda)
        {
            if (Venda.Id > 0)
            {
                db.Vendas.Add(Venda);
                db.SaveChanges();
            }
        }

        //Método http para remoção
        public void Delete(int id)
        {
            if (id > 0)
            {
                Venda Venda = db.Vendas.Find(id);
                db.Vendas.Remove(Venda);
                db.SaveChanges();
            }
        }
    }
}
