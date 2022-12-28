using System.Collections.Generic;

namespace Catalogo_Pecas.Interfaces
{
    public interface IRepositoryModel<P> where P : class
    {
        public interface IRepositorioModel<P> where P : class
        {
            List<P> SelecionarTodos();

            P SelecionarPK(params object[] variavel);

            P Cadastrar(P objeto);

            P Alterar(P objeto);

            public void Excluir(P objeto);

            public void ExcluirPK(params object[] variavel);

            void SaveChanges();
        }
    }
}
