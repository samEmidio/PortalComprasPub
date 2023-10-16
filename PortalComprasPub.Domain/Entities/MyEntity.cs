using PortalComprasPub.Domain.Core.Entities;

namespace PortalComprasPub.Domain.Entities
{
    public class MyEntity : BaseEntity
    {

        public MyEntity(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }



        public bool IsAdult()
        {
            return Age >= 18;
        }

    }
}
