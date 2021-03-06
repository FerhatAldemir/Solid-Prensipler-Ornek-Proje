using Microsoft.AspNetCore.Mvc;
using Example.BussinesLayer.Absraction;
using Microsoft.AspNetCore.Authorization;

namespace Example.RestFullApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;
        private readonly IUserManager<Entites.concrete.User, Core.Concrete.Result<object>> userManager;

        public InvoiceController(IInvoiceService InvoiceService,
            IUserManager<Entites.concrete.User, Core.Concrete.Result<object>> _userManager)
        {
            _invoiceService = InvoiceService;
            userManager = _userManager;   
        }
        [HttpGet("{InvoiceNumber}")]
     public ActionResult<Core.Bussines.IResult<Entites.ComplexType.Invoice>> GetInvoice(string InvoiceNumber)
        {
             
            var Item = _invoiceService.Get(x => x.Number == InvoiceNumber);

            
            return this.StatusCode((int)Item.StatusCode,Item);
        }
        [HttpGet("{InvoiceId:int}")]
        public ActionResult<Core.Bussines.IResult<Entites.ComplexType.Invoice>> GetInvoice(int InvoiceId)
        {

          
            var Item = _invoiceService.Get(x => x.LogicalRef == InvoiceId);

            return this.StatusCode((int)Item.StatusCode, Item);
        }

        [HttpDelete("{id:int}")]
        public IActionResult RemoveInvoice(int id)
        {


            var Item = _invoiceService.Delete(x=>x.LogicalRef == id);
            return this.StatusCode((int)Item.StatusCode, Item);
        }


        [HttpDelete("{Number}")]
        public IActionResult RemoveInvoice(string Number)
        {


            var Item = _invoiceService.Delete(x => x.Number == Number );
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

            return this.StatusCode((int)Item.StatusCode, Item);
        }


    }
}
