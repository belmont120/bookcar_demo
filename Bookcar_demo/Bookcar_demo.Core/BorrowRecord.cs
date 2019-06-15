using Bookcar_demo.Core.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bookcar_demo.Core
{
    [Table("BorrowRecord")]
    public class BorrowRecord : BaseEntity
    {
        [Key]
        public int BorrowRecordId { get; set; }

        public int UserId { get; set; }

        public string CarRego { get; set; }

        public User User { get; set; }
        public Car Car { get; set; }


    }
}
