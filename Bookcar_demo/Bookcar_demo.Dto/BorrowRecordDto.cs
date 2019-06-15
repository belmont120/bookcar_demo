using System;
using System.Collections.Generic;
using System.Text;

namespace Bookcar_demo.Dto
{
    public class BorrowRecordDto
    {
        public int BorrowRecordId { get; set; }

        public int UserId { get; set; }

        public string CarRego { get; set; }
    }
}
