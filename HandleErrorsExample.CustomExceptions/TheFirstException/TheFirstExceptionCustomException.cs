namespace HandleErrorsExample.CustomExceptions.TheFirstException
{
    public class TheFirstExceptionCustomException : Exception
    {
        public TheFirstExceptionCustomException()
        {
        }

        public TheFirstExceptionCustomException(string message)
            : base(message)
        {
        }

        public TheFirstExceptionCustomException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
