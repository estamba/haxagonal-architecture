using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManager.WebApiAdapter.Models
{
    public class InoviceRequest
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public string CustomerId { get; set; }
    }
}
