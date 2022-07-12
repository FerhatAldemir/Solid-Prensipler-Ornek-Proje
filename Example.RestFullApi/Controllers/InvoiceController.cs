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

        
        [HttpDelete("{id}")]
        public IActionResult RemoveInvoice(int id)
        {


            var Item = _invoiceService.Delete(id);
            return this.StatusCode((int)Item.StatusCode, Item);
        }

        [HttpPut]
        public ActionResult<Core.Bussines.IResult<Entites.ComplexType.Invoice>> UpdateInvoice([FromBody] Entites.ComplexType.Invoice Invoice)
        {
            var Item = _invoiceService.Put(Invoice);


            return this.StatusCode((int)Item.StatusCode, Item);
        }

        [HttpPost]
        public ActionResult<Core.Bussines.IResult<Entites.ComplexType.Invoice>> AddInvoice([FromBody] Entites.ComplexType.Invoice Invoice)
        {

            var Item = _invoiceService.Post(Invoice);

            return this.StatusCode((int)Item.StatusCode,Item);
        }
    }
}
