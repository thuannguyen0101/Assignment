namespace Assignment
{
    public class Product
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"{ProductId} \t {Name} \t {Price}$";
        }
    }
}