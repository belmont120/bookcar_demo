using System;

namespace Bookcar_demo.Dto
{
    public class CarDto
    {
        public string Rego { get; set; }

        public byte Seats { get; set; }

        public CarModelDto Model { get; set; }

        public MakeDto Make { get; set; }
    }
}
