using Microsoft.AspNetCore.Mvc;

namespace Example.RestFullApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Invoice : ControllerBase
    {
      [HttpGet]
     public IActionResult GetInvoice()
        {



            return Ok("");
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
