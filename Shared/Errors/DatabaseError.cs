namespace Shared.Errors
{
    public class DatabaseError : ErrorBase
    {
        public DatabaseError(string code, string message) : base(code, message) { }
    }
}
