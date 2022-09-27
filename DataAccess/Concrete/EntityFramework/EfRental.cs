using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRental : EfEntityRepositoryBase<Rental, CarsContext>, IRentalDal
    {
                
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarsContext context = new CarsContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join cu in context.Customers
                             on r.CustomerId equals cu.Id
                             join u in context.Users
                             on cu.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 CarId = r.CarId,
                                 CustomerName = cu.CompanyName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,

                             };

                return result.ToList();
            }
        }
    }
}
