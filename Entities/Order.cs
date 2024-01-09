using Course.Entities.Enums;

namespace Course.Entities
{
    public class Order
    {
        public DateTime Date { get; set; } 
        public OrderStatus status { get; set; }

    }
}