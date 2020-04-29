using System;
using System.Collections.Generic;
using System.Text;

namespace LV4_rppoon.Dekorater
{
    class DiscountedItem : RentableDecorator
    {
        private readonly double Discount;
        public DiscountedItem(IRentable rentable, double discount) : base(rentable)
        {
            this.Discount = discount;
        }
        public override double CalculatePrice()
        {
            return base.CalculatePrice() * (1 - Discount/100);
        }
        public override String Description
        {
            get
            {
                return base.Description + ", now at " + Discount + "% off!";
            }
        }
    }
}
