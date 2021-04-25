using InvoiceManager.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManger.Core.Ports
{
   public  interface INotificationService
    {
        void Send(Invoice invoice);
    }
}
