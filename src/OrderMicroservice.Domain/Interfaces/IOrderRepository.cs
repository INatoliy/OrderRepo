using OrderMicroservice.Domain.Aggregates;

namespace OrderMicroservice.Domain.Interfaces
{
    public interface IOrderRepository
    {
        Task CreateOrderAsync(OrderAggregate order, CancellationToken cancellationToken);
        Task<OrderAggregate> GetByIdAsync(long orderId, CancellationToken cancellationToken);
        Task<List<OrderAggregate[]>> GetByFilterAsync(CancellationToken cancellationToken);
    }
}
