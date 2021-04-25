using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManager.Core.Domain
{
    public class Invoice
    {
        public Period Period { get; set; }
        public double Amount { get; set; }
        public Customer Customer { get; set; }
    }
}
