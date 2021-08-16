namespace CodeLab.Scoreboard.Domain.ValueObjects
{
    public class FullName
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public FullName(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
    }
}
