using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bookcar_demo.Core
{
    [Table("CarModel")]
    public class CarModel
    {
        public CarModel()
        {
            Cars = new HashSet<Car>();
        }

        [Key]
        public int CarModelId { get; set; }

        [MaxLength(255)]
        public string ModelName { get; set; }

        public int MakeId { get; set; }

        //Navigation Properties
        public ICollection<Car> Cars { get; set; }
    }
}
