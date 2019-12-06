using FCP.Core.Entities;

namespace FCP.Entities.Concrete
{
    public class Category: IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}