using CodeLab.Scoreboard.Domain.Exceptions.ValueObjects;
using System;

namespace CodeLab.Scoreboard.Domain.ValueObjects
{
    public sealed class BirthDate : IEquatable<DateTime>
    {
        public DateTime Date { get; private set; }

        public BirthDate(DateTime date)
        {
            Date = date;
        }

        public bool IsValid() => Date <= DateTime.Now.Date;

        public void Validate()
        {
            if (!IsValid())
            {
                throw new BirthDateException();
            }
        }

        public bool Equals(DateTime other)
        {
            return Date.Date == other.Date;
        }

        public static BirthDate CreateValid(DateTime birthDate)
        {
            BirthDate date = new(birthDate);
            date.Validate();
            return date;
        }
    }
}
