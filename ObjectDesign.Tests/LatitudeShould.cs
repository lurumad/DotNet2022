using FluentAssertions;

namespace ObjectDesign.Tests
{
    public class latitude_should
    {
        [Theory]
        [InlineData(-91)]
        [InlineData(91)]
        public void be_in_a_valid_range(int value)
        {
            Action latitude = () => Latitude.FromScalar(value);
            latitude.Should().Throw<ArgumentOutOfRangeException>().WithMessage($"Latitude must be in range [-90; 90] (Parameter 'value')\r\nActual value was {value}.");
        }
    }
}

