using SGRB.AppplicationCore.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGRB.Infrastructure.Repository
{
    public class DapperRepository <TEntity> : IRepository<TEntity> where TEntity : class
    {
        public TEntity Adicionar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Buscar(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public TEntity ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
