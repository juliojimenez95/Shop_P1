﻿namespace Shop_P1
{
    public abstract class Product : Ipay
    {
        public string Description { get; set; }
        public int Id { get; set; }

        public decimal Price { get; set; }
        public float Tax { get; set; }
        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $" description: {Description} - id :{Id} - price :{Price} - tax: {Tax} ";
        }


    }
}
