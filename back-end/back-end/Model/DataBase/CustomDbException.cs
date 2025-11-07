namespace back_end.Model.DataBase
{
    public class CustomDbException : Exception
    {
        public CustomDbException() { }

        public CustomDbException(string message) : base(message) { }

        public CustomDbException(string message, Exception inner) : base(message, inner) { }
    }
}
