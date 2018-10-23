using System;
using System.Collections.Generic;
using System.Net;
using DemoTask1.DataAccess.Models;
using DemoTask1.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemoTask1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TariffController : ControllerBase
    {
        private readonly ITariffComparerService _comparerService;

        public TariffController(ITariffComparerService comparerService)
        {
            _comparerService = comparerService;
        }

        /// <summary>
        ///     Gets the Tariff list to compare.
        /// </summary>
        /// <param name="consumption">The consumption to get the tariffs for.</param>
        /// <returns>A collection of the tariffs for the provided consumption.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<CompareResult>), (int) HttpStatusCode.OK)]
        [ProducesResponseType((int) HttpStatusCode.BadRequest)]
        public IActionResult GetTariffs([FromQuery] int consumption)
        {
            try
            {
                return Ok(_comparerService.Compare(consumption));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}