using ControlHub.BL;
using Microsoft.AspNetCore.Mvc;

namespace ControlHub.Api.Controllers
{
    public class FibonacciController : BaseController
    {
        private readonly IFibonacciBL _FibonacciBL;
        public FibonacciController(IFibonacciBL FibonacciBL)
        {
            _FibonacciBL = FibonacciBL;
        }

        [HttpGet("{index}")]
        public IActionResult GetValueFibonacci(int index)
        {
            try
            {
                var Fibonacci = _FibonacciBL.GetValueFibonacci(index);
                return Ok(Fibonacci);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
