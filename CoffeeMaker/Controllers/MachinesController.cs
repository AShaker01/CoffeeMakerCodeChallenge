using CoffeeMaker.Application.Interfaces;
using CoffeeMaker.Domain.Request.CoffeeMachine;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoffeeMaker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachinesController : ControllerBase
    {
        private readonly ICoffeeMachineService _coffeeMachineService;
        public MachinesController(ICoffeeMachineService coffeeMachineService)
        {
            _coffeeMachineService = coffeeMachineService;
        }
        [Route("Filter")]
        [HttpPost]
        public async Task<IActionResult> Filter([FromBody] CoffeeMachineFilterRequest filterRequest)
        {
            return Ok(await _coffeeMachineService.FilterCoffeeMachines(filterRequest));
        }
    }
}
