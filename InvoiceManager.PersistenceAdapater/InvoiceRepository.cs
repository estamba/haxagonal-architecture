using InvoiceManager.Core.Domain;
using InvoiceManger.Core.Ports;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManager.PersistenceAdapater
{
    public class InvoiceRepository : IInvoiceRepository
    {
        public object GetInvoiceData(string UserId, Period period)
        {
            // Get Data via ORM
            return new { };
        }

        public void Save(Invoice invoice)
        {
            // Save Data via ORM
        }
    }
}
