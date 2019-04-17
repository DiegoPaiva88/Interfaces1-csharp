﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax;  }
        }

        public override string ToString()
        {
            return "Basic Payment: "
                + BasicPayment.ToString("F2", CultureInfo.InstalledUICulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InstalledUICulture)
                + "\nTotal payment: "
                + TotalPayment.ToString("F2", CultureInfo.InstalledUICulture);
        }
    }
}
