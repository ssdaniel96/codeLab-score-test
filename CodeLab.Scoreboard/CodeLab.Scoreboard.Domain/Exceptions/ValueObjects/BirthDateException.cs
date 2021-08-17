namespace CodeLab.Scoreboard.Domain.Exceptions.ValueObjects
{
    public class BirthDateException : DomainException
    {
        private static readonly string _defaultMessage = "A data é invalida";
        public BirthDateException() : base(_defaultMessage)
        {

        }
    }
}
