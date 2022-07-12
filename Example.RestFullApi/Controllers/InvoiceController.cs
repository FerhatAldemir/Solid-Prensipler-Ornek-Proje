using Microsoft.AspNetCore.Mvc;
using Example.BussinesLayer.Absraction;
using System.Linq;
using System.Collections.Generic;
using System.Net;

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
     public ActionResult<Core.Bussines.IResult<Entites.ComplexType.Invoice>> GetInvoice()
        {

            var Item = _invoiceService.Get(x => x.Number == "00001");
            
            return this.StatusCode((int)Item.StatusCode,Item);
        }


        [HttpDelete]
        public IActionResult RemoveInvoice()
        {



            return BadRequest("");
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
