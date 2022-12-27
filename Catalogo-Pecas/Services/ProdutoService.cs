using Catalogo_Pecas.Repositories;

namespace Catalogo_Pecas.Services
{
    public class ProdutoService
    {
        public RepositoryProduto oRepositoryProduto { get; set; }

        public ProdutoService()
        {
            oRepositoryProduto = new RepositoryProduto();
        }
    }
}
