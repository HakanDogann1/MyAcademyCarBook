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
    public class EfPriceDal : GenericRepository<Price>, IPriceDal
    {
        private readonly CarBookContext _context;
        public EfPriceDal(CarBookContext context) : base(context)
        {
            _context = context;
        }

        public List<Price> GetPricesWithCars()
        {
            return _context.Prices.Include(x=>x.Car).ThenInclude(x=>x.Brand).ToList();
            
        }
    }
}
