namespace HandleErrorsExample.CustomExceptions.TheSecondException
{
    public class TheSecondExceptionCustomException : Exception
    {
        public TheSecondExceptionCustomException()
        {
        }

        public TheSecondExceptionCustomException(string message)
            : base(message)
        {
        }

        public TheSecondExceptionCustomException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
