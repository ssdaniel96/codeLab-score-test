using CodeLab.Scoreboard.Domain.ValueObjects;
using System;

namespace CodeLab.Scoreboard.Domain.Entities
{
    public sealed class Employee : Entity
    {
        public string FirstName => FullName.Name;
        public string LastName => FullName.LastName;

        public FullName FullName { get; private set; }
        public BirthDate BirthDate { get; private set; }
        public bool IsRetired { get; private set; }

        public Employee(string name, string lastName = null, DateTime? birthDate = null)
        {
            FullName = FullName.CreateValid(name, lastName);
            BirthDate = birthDate.HasValue ? BirthDate.CreateValid(birthDate.Value) : null;
            IsRetired = false;
        }
    }
}
