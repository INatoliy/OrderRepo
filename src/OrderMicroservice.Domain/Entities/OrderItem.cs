namespace OrderMicroservice.Domain.Entities
{
    public class OrderItem
    {
        public long ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
