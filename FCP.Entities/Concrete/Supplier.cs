
using FCP.Core.Entities;

namespace FCP.Entities.Concrete
{
    public class Supplier : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
