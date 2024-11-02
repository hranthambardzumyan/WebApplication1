using System.ComponentModel.DataAnnotations;

namespace WebApplication1
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
