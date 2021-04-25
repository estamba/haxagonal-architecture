using InvoiceManager.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManger.Core.Ports
{
    public interface IInvoiceService
    {
     void Generate(string userId, Period period);
    }
}
