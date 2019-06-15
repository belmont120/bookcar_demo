using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bookcar_demo.Core
{
    [Table("Make")]
    public class Make
    {
        public Make()
        {
            Models = new HashSet<CarModel>();
        }

        [Key]
        public int MakeId { get; set; }

        [MaxLength(255)]
        public string MakeName { get; set; }

        public ICollection<CarModel> Models { get; set; }


    }
}
