namespace HomeWork.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Product[] Products { get; set; }
        public int TotalSum { get; set; }
    }
}