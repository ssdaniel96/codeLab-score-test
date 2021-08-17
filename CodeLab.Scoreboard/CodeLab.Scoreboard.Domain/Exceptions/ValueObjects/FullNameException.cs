namespace CodeLab.Scoreboard.Domain.Exceptions.ValueObjects
{
    public class FullNameException : DomainException
    {
        private static readonly string _messageDefault = "O nome está invalido.";
        public FullNameException() : base(_messageDefault)
        {

        }
    }
}
