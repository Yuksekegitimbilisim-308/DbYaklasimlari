using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEfProject.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int DoorCount { get; set; }
        public int? GlassCount { get; set; }
        public int BrandId { get; set; }
        public Brand Brands { get; set; }
    }
}
