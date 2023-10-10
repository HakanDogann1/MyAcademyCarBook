using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Concrete;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.BusinessLayer.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void TAdd(Brand entity)
        {
            _brandDal.Add(entity);
        }

        public List<Brand> TGetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand TGetByFilter(Expression<Func<Brand, bool>> filter)
        {
            return _brandDal.GetByFilter(filter);
        }

        public Brand TGetById(int id)
        {
            return _brandDal.GetById(id);
        }

        public void TRemove(int id)
        {
            _brandDal.Remove(id);
        }

        public void TUpdate(Brand entity)
        {
            _brandDal.Update(entity);
        }
    }
}
