namespace Ex28_ComprasEnumEComposicoes.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price {get; set;}
        public Product Product { get; set; }

        public OrderItem(Product product, int quantity) 
        {
            Product = product;
            Quantity = quantity;
            Price = SubTotal();
        }

        public double SubTotal()
        {
            return Product.Price * Quantity;
        }

        public override string ToString()
        {
            return string.Concat(Product.Name, ", ", "Quantity: ", Quantity, ", ","Subtotal: $", Price.ToString("F2",System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}
