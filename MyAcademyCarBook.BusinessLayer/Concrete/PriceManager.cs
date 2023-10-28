using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.BusinessLayer.Concrete
{
    public class PriceManager : IPriceService
    {
        private readonly IPriceDal _priceDal;

        public PriceManager(IPriceDal priceDal)
        {
            _priceDal = priceDal;
        }

        public void TAdd(Price entity)
        {
            _priceDal.Add(entity);
        }

        public List<Price> TGetAll()
        {
            return _priceDal.GetAll();
        }

        public Price TGetByFilter(Expression<Func<Price, bool>> filter)
        {
            return _priceDal.GetByFilter(filter);
        }

        public Price TGetById(int id)
        {
            return _priceDal.GetById(id);
        }

        public List<Price> TGetPricesWithCars()
        {
            return _priceDal.GetPricesWithCars();
        }

        public void TRemove(int id)
        {
            _priceDal.Remove(id);
        }

        public void TUpdate(Price entity)
        {
            _priceDal.Update(entity);
        }
    }
}
