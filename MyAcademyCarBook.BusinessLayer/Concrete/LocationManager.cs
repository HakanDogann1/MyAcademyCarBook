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
    public class LocationManager : ILocationService
    {
        private readonly ILocationDal _locationDal;

        public LocationManager(ILocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        public void TAdd(Location entity)
        {
            _locationDal.Add(entity);
        }

        public List<Location> TGetAll()
        {
            return _locationDal.GetAll();
        }

        public Location TGetByFilter(Expression<Func<Location, bool>> filter)
        {
            return _locationDal.GetByFilter(filter);
        }

        public Location TGetById(int id)
        {
            return _locationDal.GetById(id);
        }

        public void TRemove(int id)
        {
            _locationDal.Remove(id);
        }

        public void TUpdate(Location entity)
        {
            _locationDal.Update(entity);
        }
    }
}
