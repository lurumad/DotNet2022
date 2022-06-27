using FluentAssertions;

namespace ObjectDesign.Tests
{
    public class latitude_should
    {
        [Fact]
        public void be_in_a_valid_range()
        {
            Action latitude = () => Latitude.FromScalar(-190);
            latitude.Should().Throw<ArgumentOutOfRangeException>().WithMessage("Latitude must be in range [-90; 90] (Parameter 'value')\r\nActual value was -190.");
        }
    }
}

