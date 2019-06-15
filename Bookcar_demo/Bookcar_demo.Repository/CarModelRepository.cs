using Bookcar_demo.Core;
using Bookcar_demo.Repository.Contexts;
using Bookcar_demo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookcar_demo.Repository
{
    public class CarModelRepository : Repository<CarModel>, ICarModelRepository
    {
        public CarModelRepository(AppDbContext context)
            : base(context)
        {
        }

    }
}
