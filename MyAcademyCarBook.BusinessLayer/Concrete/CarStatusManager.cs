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
    public class CarStatusManager : ICarStatusService
    {
        private readonly ICarStatusDal _carStatusDal;

        public CarStatusManager(ICarStatusDal carStatusDal)
        {
            _carStatusDal = carStatusDal;
        }

        public void TAdd(CarStatus entity)
        {
            _carStatusDal.Add(entity);
        }

        public List<CarStatus> TGetAll()
        {
            return _carStatusDal.GetAll();
        }

        public CarStatus TGetByFilter(Expression<Func<CarStatus, bool>> filter)
        {
            return _carStatusDal.GetByFilter(filter);
        }

        public CarStatus TGetById(int id)
        {
            return _carStatusDal.GetById(id);
        }

        public void TRemove(int id)
        {
            _carStatusDal.Remove(id);
        }

        public void TUpdate(CarStatus entity)
        {
            _carStatusDal.Update(entity);
        }
    }
}
