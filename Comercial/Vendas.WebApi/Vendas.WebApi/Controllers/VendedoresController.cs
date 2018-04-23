using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Vendas.WebApi.DataContexts;
using Vendas.WebApi.Models;

namespace Vendas.WebApi.Controllers
{
    public class VendedoresController : ApiController
    {
        private VendaDataContexts db = new VendaDataContexts();

        //Método http para consulta
        public List<Vendedor> Get()
        {
            return db.Vendedores.ToList();
        }

        //Método http para inclusão
        public void Post(Vendedor vendedor)
        {
            if (vendedor.Id > 0)
            {
                db.Vendedores.Add(vendedor);
                db.SaveChanges();
            }
        }

        //Método http para remoção                              
        public void Delete(int id)
        {
            if (id > 0)
            {
                Vendedor vendedor = db.Vendedores.Find(id);
                db.Vendedores.Remove(vendedor);
                db.SaveChanges();
            }
        }
    }
}
