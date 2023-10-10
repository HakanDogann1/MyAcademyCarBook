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
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void TAdd(Car entity)
        {
            if (entity.Year >= 2010 && entity.Prices.Count > 0 && entity.Km <= 500000)
            {
                _carDal.Add(entity);
            }
        }

        public List<Car> TGetAll()
        {
            return _carDal.GetAll();
        }

        public Car TGetByFilter(Expression<Func<Car, bool>> filter)
        {
            return _carDal.GetByFilter(filter);
        }

        public Car TGetById(int id)
        {
            if (id != null)
            {
                return _carDal.GetById(id);

            }
            return _carDal.GetById(0);
        }

        public void TRemove(int id)
        {
            _carDal.Remove(id);
        }

        public void TUpdate(Car entity)
        {
            _carDal.Update(entity);
        }
    }
}
