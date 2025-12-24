using HandleErrorsExample.Interfaces.TheSecondException;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandleErrorsExample.Controllers.TheSecondException
{
    [ApiController]
    [Route("[controller]")]
    public class TheSecondExceptionController(ISecondException secondException) : ControllerBase
    {
        private readonly ISecondException _secondException = secondException ?? throw new ArgumentNullException(nameof(secondException));

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("GetTheSecondException")]
        public Task GetTheSecondException()
        {
            return _secondException.GetSecondException();
        }
    }
}
