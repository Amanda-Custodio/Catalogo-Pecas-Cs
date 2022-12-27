using Catalogo_Pecas.Interfaces;
using Catalogo_Pecas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Catalogo_Pecas.Repositories
{
    public class RepositoryBase<P> : IRepositoryModel<P>, IDisposable where P : class
    {
        protected CatalogoContext _Contexto;
        public bool _SaveChanges = true;

        public RepositoryBase(bool saveChanges = true)
        {
            _SaveChanges = saveChanges;
            _Contexto = new CatalogoContext();
        }
        public P Alterar(P objeto)
        {
            _Contexto.Entry(objeto).State = EntityState.Modified;

            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }

            return objeto;
        }

        public P Cadastrar(P objeto)
        {
            _Contexto.Set<P>().Add(objeto);
            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }

            return objeto;
        }

        public void Dispose()
        {
            _Contexto.Dispose();
        }

        public void Excluir(P objeto)
        {
            _Contexto.Set<P>().Remove(objeto);
            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }
        }

        public void ExcluirPK(params object[] variavel)
        {
            var obj = SelecionarPK(variavel);
            ExcluirPK(obj);
        }

        public void SaveChanges()
        {
            _Contexto.SaveChanges();
        }

        public P SelecionarPK(params object[] variavel)
        {
            return _Contexto.Set<P>().Find(variavel);
        }

        public List<P> SelecionarTodos()
        {
            return _Contexto.Set<P>().ToList<P>();
        }
    }
}
