using PortalComprasPub.Domain.Core.Entities;
using PortalComprasPub.Domain.ValueObjects;

namespace PortalComprasPub.Domain.Entities
{
    public class MyEntity : BaseEntity
    {

        public MyEntity(string name, string lastName, int age)
        {
            Name = FullName.Create(name, lastName);
            Age = age;
        }
        public FullName Name { get; set; }
        public int Age { get; set; }

        public bool IsAdult()
        {
            return Age >= 18;
        }

    }
}
