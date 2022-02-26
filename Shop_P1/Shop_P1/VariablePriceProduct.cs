namespace Shop_P1
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }
        public override decimal GetValueToPay()
        {
            return (Price * (decimal)Quantity) + (Price * (decimal)Quantity * (decimal)Tax);
        }
        public override string ToString()
        {
            return $"\n{base.ToString()}" + $"\nMeasurement........: {$"{Measurement}"}"+
                $"\nQuantity.........:   {$"{Quantity}"}"
                + $"\nValue to pay: {$"{GetValueToPay():C2}",18}";
        }
    }
}
