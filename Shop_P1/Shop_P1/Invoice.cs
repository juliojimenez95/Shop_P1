namespace Shop_P1
{
    internal class Invoice : Ipay
    {
        private List<Product> _products= new List<Product>();

        public Invoice()
        {

        }

        public void AddProduct(Product p1) { 

            _products.Add(p1);
        }

        public decimal GetValueToPay()
        {
            decimal total = 0;
            foreach (Product product in _products)
            {
                total += product.GetValueToPay() ;
            }
            return total;
        }

        public override string ToString()
        {
            string payroll = "";
            foreach(Product product in _products)
            {
                payroll+= product.ToString()+"\n";
            }
            return "------------------------------"+
               $"\n{payroll}                    ================\n" +
              $"total:         {$"{GetValueToPay():C2}",18}";


        }

    }
}
