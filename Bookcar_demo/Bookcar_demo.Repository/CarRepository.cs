using Bookcar_demo.Core;
using Bookcar_demo.Repository.Contexts;
using Bookcar_demo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookcar_demo.Repository
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(AppDbContext context)
            : base(context)
        {
        }

        public bool CheckCarExists(string carRego)
        {
            return AppDbContext.Cars.Any(c => c.IsActive == true && c.Rego.Equals(carRego));
        }

        public IEnumerable<Car> GetAvailableCars(int borrowExpInHours)
        {
            return AppDbContext.Cars.Where(c => c.IsActive == true && AppDbContext.BorrowRecords.Any(r => r.IsActive == true && r.CarRego.Equals(c.Rego) && r.CreateDate > DateTime.Now.AddHours(-borrowExpInHours))).ToList();
        }
    }
}
