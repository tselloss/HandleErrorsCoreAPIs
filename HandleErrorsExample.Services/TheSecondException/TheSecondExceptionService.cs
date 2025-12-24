using HandleErrorsExample.CustomExceptions.TheSecondException;
using HandleErrorsExample.Interfaces.TheSecondException;

namespace HandleErrorsExample.Services.TheSecondException
{
    public class TheSecondExceptionService : ISecondException
    {
        public Task GetSecondException()
        {
            throw new TheSecondExceptionCustomException();
        }
    }
}
