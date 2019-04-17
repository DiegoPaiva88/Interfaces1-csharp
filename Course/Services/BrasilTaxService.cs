using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Services
{
    class BrasilTaxService
    {
        public double Tax(double amount)
        {
            if (amount <=100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
