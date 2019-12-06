
using FCP.Core.Entities;

namespace FCP.Entities.Concrete
{
    public class Product : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public bool Discontinued { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
