using CodeLab.Scoreboard.Domain.ValueObjects;
using FluentAssertions;
using Xunit;

namespace CodeLab.Scoreboard.Domain.Test.ValueObjects
{
    public class FullNameTest
    {
        [Fact]
        public void Equals_WithString_ReturnTrue()
        {
            string fullNameString = "José Cleiton Mendonça";
            FullName fullNameObject = new("José", "Cleiton Mendonça");

            Assert.True(fullNameObject.Equals(fullNameString));
        }

        [Fact]
        public void IsValid_WithInvalidFullName_ReturnFalse()
        {
            FullName invalidFullName = new("Al", "Joana");

            Assert.False(invalidFullName.IsValid());
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void IsValid_WithValidNameAndEmptyLastName_ReturnsTrue(string nullOrEmpty)
        {
            FullName validName = new("ALX", nullOrEmpty);

            validName.IsValid(true).Should().BeTrue();
        }

        [Fact]
        public void FullNamesMustBeEquals()
        {
            FullName name1 = new("Leo, Mendonça");
            FullName name2 = new("Leo, Mendonça");

            Assert.True(name1 == name2);
        }

    }
}
