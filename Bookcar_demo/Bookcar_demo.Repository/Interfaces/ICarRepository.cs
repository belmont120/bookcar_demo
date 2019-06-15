using Bookcar_demo.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookcar_demo.Repository.Interfaces
{
    public interface ICarRepository : IRepository<Car>
    {
        bool CheckCarExists(string carRego);

        IEnumerable<Car> GetAvailableCars(int borrowExpInHours);
    }

   
}
