using Microsoft.AspNetCore.Mvc;
using NPFTestApi.Core.Interfaces;
using NPFTestApi.Core.Models;
using NPFTestApi.Core.Models.Divisibility.Request;
using System;
using System.Net;

namespace NPFTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisibilityController : ControllerBase
    {
        private readonly IDivisibilityService _divisibilityService;
        public DivisibilityController(IDivisibilityService divisibilityService)
        {
            _divisibilityService = divisibilityService;
        }
        [HttpPost]
        [Route("CheckDivisibilityOfEleven")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.InternalServerError)]
        public ActionResult<bool> CheckDivisibilityOfEleven(MultipleRequest Numbers)
        {
            try
            {
                return Ok(
                    new Notification(
                        _divisibilityService.IsNumberDivisibleByEleven(Numbers.NumbersInt())
                    )
                );

            }
            catch (Exception ex)
            {
                return BadRequest(new Notification()
                    .AddError(ex.Message));
            }
        }
    }
}