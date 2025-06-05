using OrderMicroservice.Domain.Aggregates;
using OrderMicroservice.Domain.Interfaces;

namespace OrderMicroservice.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Task CreateOrderAsync(OrderAggregate order, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("!!!!!!!!!!ЕБАНА РОТ!!!!!!!!!!");
        }

        public Task<List<OrderAggregate[]>> GetByFilterAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<OrderAggregate> GetByIdAsync(long orderId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
