using HandleErrorsExample.CustomExceptions.TheFirstException;
using HandleErrorsExample.Interfaces.TheFirstException;

namespace HandleErrorsExample.Services.TheFirstException
{
    public class TheFirstExceptionService : IFirstException
    {
        public Task GetFirstException()
        {
            throw new TheFirstExceptionCustomException();
        }
    }
}
