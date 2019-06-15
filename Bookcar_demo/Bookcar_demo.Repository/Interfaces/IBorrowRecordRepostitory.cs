using Bookcar_demo.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookcar_demo.Repository.Interfaces
{
    public interface IBorrowRecordRepostitory : IRepository<BorrowRecord>
    {
        bool CheckCarAvailability(string carRego, int expInHours);
    }
}
