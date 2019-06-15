using Bookcar_demo.Core;
using Bookcar_demo.Repository.Contexts;
using Bookcar_demo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookcar_demo.Repository
{
    public class BorrowRecordRepository : Repository<BorrowRecord>, IBorrowRecordRepostitory
    {
        public BorrowRecordRepository(AppDbContext context)
            : base(context)
        {
        }

        public bool CheckCarAvailability(string carRego, int expInHours)
        {

            return !AppDbContext.BorrowRecords.Any(r => r.IsActive == true && r.CarRego.Equals(carRego) && r.CreateDate > DateTime.Now.AddHours(-expInHours));
        }
    }
}
