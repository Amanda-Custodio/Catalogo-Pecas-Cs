using Catalogo_Pecas.Interfaces;
using Catalogo_Pecas.Models;

namespace Catalogo_Pecas.Repositories
{
    public class RepositoryProduto : RepositoryBase<Produtos>, IRepositoryProduto
    {
        public RepositoryProduto(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
