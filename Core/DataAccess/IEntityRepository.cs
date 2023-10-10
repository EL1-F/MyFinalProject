using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        //mesala kategorye göre getir ya da belli bir şarta göre getir demek için genel kullanım gibi
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        //Detaya gitmek için kullanılır
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
