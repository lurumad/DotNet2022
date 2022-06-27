using FluentAssertions;

namespace ObjectDesign.Tests
{
    public class longitude_should
    {
        [Theory]
        [InlineData(-181)]
        [InlineData(181)]
        public void be_in_a_valid_range(int value)
        {
            Action longitude = () => Longitude.FromScalar(value);
            longitude.Should().Throw<ArgumentOutOfRangeException>().WithMessage($"Longitude must be in range [-180; 180] (Parameter 'value')\r\nActual value was {value}.");
        }
    }
}
