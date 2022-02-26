namespace Shop_P1
{
    public class FixePriceProduct : Product
    {


        public override decimal GetValueToPay()
        {
            return Price + ((decimal)Tax * Price);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
            $"\nValue to pay: {$"{GetValueToPay():C2}",18}";
        }
    }
}
