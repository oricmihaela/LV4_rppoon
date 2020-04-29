using System;
using System.Collections.Generic;
using System.Text;

namespace LV4_rppoon.Dekorater
{
    interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }
}
