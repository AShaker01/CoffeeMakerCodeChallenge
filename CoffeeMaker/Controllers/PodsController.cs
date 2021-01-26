using CoffeeMaker.Application.Interfaces;
using CoffeeMaker.Domain.Request.CoffeePods;
using CoffeeMaker.Domain.Response.CoffeePods;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMaker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PodsController : ControllerBase
    {
        private readonly ICoffeePodService _coffeePodService;
        public PodsController(ICoffeePodService coffeePodService)
        {
            _coffeePodService = coffeePodService;
        }
        [Route("Filter")]
        [HttpPost]
        public async Task<IActionResult> Filter([FromBody] CoffeePodFilterRequest filterRequest)
        {
            return Ok(await _coffeePodService.FilterCoffeePods(filterRequest));
        }
    }
}
