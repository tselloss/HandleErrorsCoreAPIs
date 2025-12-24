using HandleErrorsExample.Interfaces.TheFirstException;
using HandleErrorsExample.Interfaces.TheSecondException;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandleErrorsExample.Controllers.TheFirstException
{
    [ApiController]
    [Route("[controller]")]
    public class TheFirstExceptionController(IFirstException firstExcetion) : ControllerBase
    {
        private readonly IFirstException _firstExcetion = firstExcetion ?? throw new ArgumentNullException(nameof(firstExcetion));

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("GetTheFirstException")]
        public Task GetTheFirstException()
        {
            return  _firstExcetion.GetFirstException();
        }
    }
}
