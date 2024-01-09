using Course.Entities.Enums;

namespace Course.Entities
{
    public class Order
    {
        public DateTime Date { get; set; } 
        public OrderStatus Status { get; set; }

        public Order ()
        {   
        }
        public Order(DateTime date, OrderStatus status)
        {
            Date = date;
            Status = status;
        }
        
    }
}