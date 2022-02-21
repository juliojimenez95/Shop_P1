namespace Shop_P1
{
    internal class Invoice : Ipay
    {
        private List<Product> Products { get; set; }

        public void AddProduct(Product p) { 

            Products.Add(p);
        }

        public decimal GetValueToPay()
        {
            throw new NotImplementedException();
        }
    }
}
