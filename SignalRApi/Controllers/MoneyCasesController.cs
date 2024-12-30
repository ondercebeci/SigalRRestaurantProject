using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinessLayer.Abstract;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyCasesController : ControllerBase
    {
        private readonly IMoneyCaseService _moneyCaseService;

        public MoneyCasesController(IMoneyCaseService moneyCaseService)
        {
            _moneyCaseService = moneyCaseService;
        }
        [HttpGet("TTotalMoneyCaseAmount")]
       public IActionResult TTotalMoneyCaseAmount()
        {
            return Ok(_moneyCaseService.TTotalMoneyCaseAmount());
        }
    }
}
