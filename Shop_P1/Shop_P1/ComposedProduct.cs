namespace Shop_P1
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product> Products { get; set; }

        public override decimal GetValueToPay()
        {
            decimal payroll = 0;
            foreach (Product product in Products)
            {
                Console.WriteLine(product);
                payroll += product.GetValueToPay() - (product.GetValueToPay() * (decimal)Discount);
            }
            return payroll;
        }


        public override string ToString()
        {
            string product = "";
            foreach (Product prod in Products)
            {
                product += prod.Description + " ,";
            }
            return $"{Id} {Description}" +
            $"\n Products...: {product}" +
            $"\n Discount...: {$"{Discount:P2}",15}" +
            $"\nValue to pay: {$"{GetValueToPay():C2}",18}";
        }
    }
}
