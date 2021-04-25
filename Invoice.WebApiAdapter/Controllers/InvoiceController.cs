using InvoiceManager.WebApiAdapter.Models;
using InvoiceManger.Core.Ports;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManager.WebApiAdapter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            this.invoiceService = invoiceService;
        }
        [HttpPost("generate")]
        public IActionResult Generate(InoviceRequest inoviceRequest)
        {
            invoiceService.Generate(inoviceRequest.CustomerId, new Core.Domain.Period(inoviceRequest.Month, inoviceRequest.Year));
            
            return Ok();
        }
    }
}
