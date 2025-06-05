using OrderMicroservice.Application.Commands;
using OrderMicroservice.Application.Interfaces;
using OrderMicroservice.Domain.Aggregates;
using OrderMicroservice.Domain.Interfaces;

namespace OrderMicroservice.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        // private readonly IUnitOfWork _unitOfWork;
        public OrderService(IOrderRepository orderRepository)//, IUnitOfWork unitOfWork)
        {
            _orderRepository = orderRepository;
            //     _unitOfWork = unitOfWork;

        }


        public async Task<long> CreateBookingAsync(CreateOrderCommand command, CancellationToken cancellationToken = default)
        {
            var order = OrderAggregate.Initialize(command.UserId, DateTimeOffset.Now);
            await _orderRepository.CreateOrderAsync(order, cancellationToken);
            return order.Id;
        }
        public async Task CancelBookingAsync(CancelOrderCommand command, CancellationToken cancellationToken = default)
        {
            var order = await _orderRepository.GetByIdAsync(command.OrderId, cancellationToken);

            if (order == null || order.Id <= 0) throw new Exception("Не удалось найти бронирование.");

            order.Cancel();
            _orderRepository.CreateOrderAsync(order, cancellationToken);

        }
    }
}
