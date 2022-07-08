using Microsoft.AspNetCore.Mvc;
using Example.BussinesLayer.Absraction;
using System.Linq;

namespace Example.RestFullApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;
        public InvoiceController(IInvoiceService InvoiceService)
        {
            _invoiceService = InvoiceService;
        }
      [HttpGet]
     public IActionResult GetInvoice()
        {
            return Ok(_invoiceService.Get(x=>x.Number == "00001"));
        }


        [HttpDelete]
        public IActionResult RemoveInvoice()
        {



            return Ok("");
        }

        [HttpPut]
        public IActionResult UpdateInvoice()
        {



            return Ok("");
        }

        [HttpPost]
        public IActionResult AddInvoice()
        {



            return Ok("");
        }
    }
}
