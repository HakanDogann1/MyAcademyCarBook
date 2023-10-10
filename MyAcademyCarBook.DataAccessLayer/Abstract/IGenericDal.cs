using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(int id);
        T GetById(int id);
        T GetByFilter(Expression<Func<T, bool>> filter);
        List<T> GetAll();
    }
}
