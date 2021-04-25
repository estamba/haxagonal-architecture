using InvoiceManager.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManger.Core.Ports
{
    public interface IInvoiceRepository
    {
        void Save(Invoice invoice);
        object GetInvoiceData(string UserId, Period period);
    }
}
