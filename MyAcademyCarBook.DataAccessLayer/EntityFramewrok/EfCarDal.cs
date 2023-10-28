using Microsoft.EntityFrameworkCore;
using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Concrete;
using MyAcademyCarBook.DataAccessLayer.Repositories;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.DataAccessLayer.EntityFramewrok
{
    public class EfCarDal : GenericRepository<Car>, ICarDal
    {
        private readonly CarBookContext _context;
        public EfCarDal(CarBookContext context) : base(context)
        {
            _context = context;
        }

        public List<Car> GetAllCarsWithBrands()
        {
            var values = _context.Cars.Include(x=>x.Category).Include(x=>x.Brand).Include(x=>x.CarStatus).Include(y=>y.CarStatus).ToList();
            return values;
        }
    }
}
