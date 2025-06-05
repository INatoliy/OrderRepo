using OrderMicroservice.Application.Commands;

namespace OrderMicroservice.Application.Interfaces
{
    public interface IOrderService
    {
        Task<long> CreateBookingAsync(CreateOrderCommand command, CancellationToken cancellationToken = default);
        Task CancelBookingAsync(CancelOrderCommand command, CancellationToken cancellationToken = default);
        // Task<OrderDto> GetByIdAsync(GetBookingByIdQuery idQuery, CancellationToken cancellationToken = default);
        // Task<OrderDto[]> GetByFilterAsync(GetBookingsByFilterQuery filterQuery, CancellationToken cancellationToken = default);
        // Task<OrderStatus> GetStatusByIdAsync(GetBookingStatusByIdQuery idQuery, CancellationToken cancellationToken = default);
    }
}
