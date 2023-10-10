using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TAdd(T entity);
        void TUpdate(T entity);
        void TRemove(int id);
        T TGetById(int id);
        T TGetByFilter(Expression<Func<T, bool>> filter);
        List<T> TGetAll();
    }
}
