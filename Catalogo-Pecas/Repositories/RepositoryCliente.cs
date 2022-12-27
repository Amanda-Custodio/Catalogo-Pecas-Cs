using Catalogo_Pecas.Interfaces;
using Catalogo_Pecas.Models;

namespace Catalogo_Pecas.Repositories
{
    public class RepositoryCliente : RepositoryBase<Clientes>, IRepositoryCliente
    {
        public RepositoryCliente(bool SaveChanges = true) : base(SaveChanges)
        {

        }

    }
}
