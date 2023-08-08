using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JNA.Condominio.Infra.Repositories
{
    
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity RecuperarPorId(int id);
        IEnumerable<TEntity> RecuperarTodos();
        //IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity Incluir(TEntity entity);
        void Atualizar(TEntity entity);
        void Deletar(TEntity entity);
    }    
}
