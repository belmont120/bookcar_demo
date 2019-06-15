using Bookcar_demo.Core.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookcar_demo.Core
{
    [Table("Car")]
    public class Car : BaseEntity
    {
        [Key]
        [MaxLength(20)]
        public string Rego { get; set; }

        public byte Seats { get; set; }

        public int ModelId { get; set; }

        public ICollection<BorrowRecord> BorrowRecords { get; set; }
    }
}
