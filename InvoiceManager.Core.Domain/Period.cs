using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManager.Core.Domain
{
    public class Period
    {
        public Period(int month, int year)
        {
            this.Year = year;
            this.Month = month;
        }
        public int Month { get; private set; }
        public int Year { get; private set; }
    }
}
