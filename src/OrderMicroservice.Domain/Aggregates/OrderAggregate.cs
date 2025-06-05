using OrderMicroservice.Domain.Enums;

namespace OrderMicroservice.Domain.Aggregates
{
    public class OrderAggregate
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public OrderStatus OrderStatus { get; private set; }
        public DateTimeOffset CreatedAt { get; set; }

        public OrderAggregate()
        {
        }

        private OrderAggregate(long userId, DateTimeOffset createdAt)
        {
            UserId = userId;
            OrderStatus = OrderStatus.New;
            CreatedAt = createdAt;
        }

        public static OrderAggregate Initialize(long userId, DateTimeOffset createdAt)
        {
            if (userId <= 0) throw new Exception("Индетификатор пользовотеля должен быть больше 0");
            return new OrderAggregate(userId, createdAt);
        }

        public void Cancel()
        {
            if (OrderStatus == OrderStatus.Cancelled) throw new Exception("Бронирование уже было отменено");
            OrderStatus = OrderStatus.Cancelled;
        }
    }
}
