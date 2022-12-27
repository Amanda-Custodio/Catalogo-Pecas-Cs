using Catalogo_Pecas.Repositories;

namespace Catalogo_Pecas.Services
{
    public class ClienteService
    {
        public RepositoryCliente oRepositoryUsuario { get; set; }

        public ClienteService()
        {
            oRepositoryUsuario = new RepositoryCliente();
        }
    }
}
