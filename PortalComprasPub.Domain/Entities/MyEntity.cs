namespace PortalComprasPub.Domain.Entities
{
    public class MyEntity
    {

        public MyEntity(int number)
        {
            Number = number;
        }
        public int Number { get; set; }



        public bool IsEven()
        {
            return Number%2 == 0;
        }

    }
}
