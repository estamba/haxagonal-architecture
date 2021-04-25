using InvoiceManager.Core.Domain;
using InvoiceManger.Core.Ports;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManager.Core.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly INotificationService notificationService;
        private readonly IInvoiceRepository invoiceRepository;

        public InvoiceService(INotificationService notificationService, IInvoiceRepository invoiceRepository)
        {
            this.notificationService = notificationService;
            this.invoiceRepository = invoiceRepository;
        }
        public void Generate(string customerId, Period period)
        {
           var invoiceData = invoiceRepository.GetInvoiceData(customerId, period);
            notificationService.Send(GenerateInvoice(invoiceData));
        }

        private Invoice GenerateInvoice(object invoiceData)
        {
            return new Invoice();
        }
    }
}
