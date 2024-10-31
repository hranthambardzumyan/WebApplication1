namespace WebApplication1
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ProductName { get; set; }
        public int ProductCount { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
