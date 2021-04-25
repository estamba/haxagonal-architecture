using InvoiceManager.Core.Services;
using InvoiceManager.PersistenceAdapater;
using InvoiceManager.RestAdapter;
using InvoiceManger.Core.Ports;
using System;

namespace InvoiceManager.ConsoleAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IInvoiceService invoiceService = new InvoiceService(new NotificationService(),new InvoiceRepository());
            invoiceService.Generate("Nxt-Cus-01", new Core.Domain.Period(04, 2020));

        }
    }
}
