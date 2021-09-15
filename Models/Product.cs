namespace HomeWork.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; init; }
        public Currency Currency { get; set; }
    }
}