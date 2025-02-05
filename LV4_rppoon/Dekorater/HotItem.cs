﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LV4_rppoon.Dekorater
{
    class HotItem : RentableDecorator
    {
        private readonly double HotItemBonus = 1.99;
        public HotItem(IRentable rentable) : base(rentable) { }
        public override double CalculatePrice()
        {
            return base.CalculatePrice() + this.HotItemBonus;
        }
        public override String Description
        {
            get
            {
                return "Trending: " + base.Description;
            }
        }
        
    }
}
