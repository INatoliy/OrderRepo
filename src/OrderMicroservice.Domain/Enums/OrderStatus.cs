namespace OrderMicroservice.Domain.Enums
{
    public enum OrderStatus
    {
        New,          // Новый
        Paid,         // Оплачен
        Shipped,      // Доставляется
        Completed,    // Завершен
        Cancelled     // Отменен
    }
}
