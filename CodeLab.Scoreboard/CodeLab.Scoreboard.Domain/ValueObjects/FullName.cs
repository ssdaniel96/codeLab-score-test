using CodeLab.Scoreboard.Domain.Exceptions.ValueObjects;
using System;

namespace CodeLab.Scoreboard.Domain.ValueObjects
{
    public sealed class FullName : IEquatable<FullName>, IEquatable<string>
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }


        public FullName(string name, string lastName) : this(name)
        {
            LastName = lastName == string.Empty ? null : lastName;
        }

        public FullName(string name)
        {
            Name = name;
        }

        public void Validate(bool allowLastNameEmpty = false)
        {
            if (!IsValid(allowLastNameEmpty))
            {
                throw new FullNameException();
            }
        }

        public bool IsValid(bool allowLastNameEmpty = false)
        {
            return IsValidName()
                && IsValidLastName(allowLastNameEmpty);
        }

        private bool IsValidName()
        {
            return !string.IsNullOrWhiteSpace(Name)
                            && Name.Length >= 3
                            && Name.Length <= 255;
        }

        private bool IsValidLastName(bool allowLastNameEmpty)
        {
            if (allowLastNameEmpty && LastName == null)
            {
                return true;
            }

            return !string.IsNullOrWhiteSpace(LastName)
                            && LastName.Length >= 3
                            && LastName.Length <= 255;
        }

        public bool Equals(FullName other)
        {
            return Name == other.Name
                && LastName == other.LastName;
        }

        public override string ToString()
        {
            return $"{Name} {LastName}";
        }

        public bool Equals(string other)
        {
            return other == ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is string)
            {
                return Equals(obj as string);
            }
            else if (obj is FullName)
            {
                return Equals(obj as FullName);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + LastName.GetHashCode();
        }

        public static FullName CreateValid(string name, string lastName, bool allowLastNameEmpty = false)
        {
            var fullName = new FullName(name, lastName);
            fullName.Validate(allowLastNameEmpty);
            return fullName;
        }
    }
}
